using Flask.TELAS.CONTROLES;
using Flask.TELAS.METODOS;
using Flask.TELAS.METODOS.EXTENSORES;
using FlaskMODEL;
using FlaskMODEL.CONSULTAS;
using FlaskMODEL.TABELAS;
using FlaskUI;
using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask
{
    public partial class FrmRelatorio : FlaskForm
    {
        Relatorio model;
        public FrmRelatorio()
        {
            InitializeComponent();
        }
        public FrmRelatorio(int id)
        {
            InitializeComponent();

            txtID.Text = id.ToString();
            TxtID_Leave(null, new EventArgs());
        }
        private void TxtID_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
                return;

            CarregarRegistro(id);
        }

        private void CarregarRegistro(int id)
        {
            try
            {
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    var query = db.Relatorio.Where(x => x.ID == id).FirstOrDefault();

                    if (query == null)
                    {
                        Limpar(null, new EventArgs());
                        return;
                    }

                    model = query;

                    txtID.Text = model.ID.ToString("000000");
                    txtID.Ativo = false;
                    ucRTF1.RTF.Text = model.Texto;
                    txtAnalise.Text = model.Analise;

                    Modo = Modo.Alteracao;
                    ucRTF1.RTF.Select();
                }
            }
            catch (Exception ex)
            {
                Tela.InformarErro(ex);
                Limpar(null, new EventArgs());
            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            Modo = Modo.Novo;
            model = new Relatorio();
            this.LimparCampos();
            ucRTF1.RTF.Text = string.Empty;

            txtID.Ativo = true;
            txtID.Select();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!this.VerificarCamposObrigatorios())
                return;

            try
            {
                using (var db = new FlaskDatabase())
                {
                    model.Texto = ucRTF1.RTF.Text;
                    model.Salvar(Modo, false);
                }
            }
            catch (Exception ex)
            {
                Tela.InformarErro(ex);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modo != Modo.Alteracao)
                    return;

                if (!Tela.PerguntarDesejaExcluir())
                    return;

                model.Excluir();

                Limpar(null, new EventArgs());
            }
            catch (Exception ex)
            {
                Tela.InformarErroFatal(ex);
            }
        }

        private void FlaskSearchButton1_Click(object sender, EventArgs e)
        {
            int id = Tela.ConsultaGeral(new ConsultaRelatorio());
            if (id != -1)
            {
                txtID.Text = id.ToString();
                TxtID_Leave(null, new EventArgs());
            }
        }
    }
}

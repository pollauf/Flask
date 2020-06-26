using Flask.TELAS.CONTROLES;
using FlaskMODEL;
using FlaskMODEL.CONSULTAS;
using FlaskUI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.METODOS
{
    public static class Tela
    {
        public static FrmPrincipal FormPrincipal { get; set; }
        public static void Abrir(FlaskForm janela, string nomeJanela)
        {
            if (FormPrincipal == null)
                return;

            FormPrincipal.StrJanelaAberta = nomeJanela;

            //---- Selecionar Aba
            if (FormPrincipal.ucAbas.SelecionarAbaPorNome(janela.Name))
                return;

            janela.TopLevel = false;
            janela.AutoScroll = true;
            FormPrincipal.pnlMain.Controls.Add(janela);
            janela.Show();
            janela.Centralizar();

            string textoFormAberto = janela.Text;

            FormPrincipal.ucAbas.AdicionarAba(new Aba(janela, textoFormAberto));

            AtualizarPlanoFundo();
        }

        public static void Fechar()
        {
            if (VerificarCondicoesParaProsseguir())
                return;

            FormPrincipal.StrJanelaAberta = string.Empty;

            FormPrincipal.ucAbas.RemoverAba(FormPrincipal.ucAbas.AbaSelecionada.Tela.Name);
        }

        public static void AtualizarPlanoFundo()
        {
            if (FormPrincipal == null)
                return;

            if (FormPrincipal.ucAbas.Abas.Count > 0)
            {
                FormPrincipal.pnlMain.BackColor = Color.FromArgb(195, 195, 200);
                FormPrincipal.pictureBox1.Visible = false;
            }
            else
            {
                FormPrincipal.pnlMain.BackColor = FormPrincipal.BackColor;
                FormPrincipal.pictureBox1.Visible = true;
            }
        }

        /* public static void EnviarComando(ref Message m)
         {
             FormPrincipal.ucAbas.AbaSelecionada.Tela.SendWndProcCommand(ref m);
         }*/

        public static void Centralizar()
        {
            if (VerificarCondicoesParaProsseguir())
                return;

            FormPrincipal.ucAbas.AbaSelecionada.Tela.Centralizar();
        }

        private static bool VerificarCondicoesParaProsseguir()
        {
            if (FormPrincipal == null)
                return true;

            if (FormPrincipal.ucAbas.AbaSelecionada == null)
                return true;

            return false;
        }

        public static int ConsultaGeral(IConsulta consulta)
        {
            var form = new FrmConsultaGeral(consulta.Nome, consulta.Pesquisar(), consulta.Cabecalhos);
            form.ShowDialog();
            return form.ID;
        }

        public static void InformarSalvoSucesso()
        {
            MessageBox.Show("Salvo com sucesso.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void InformarExcluidoSucesso()
        {
            MessageBox.Show("Excluído com sucesso.", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool PerguntarDesejaExcluir()
        {
            if (MessageBox.Show("Deseja excluir este registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
                return true;

            return false;
        }

        public static void InformarErroFatal(Exception erro)
        {
            MessageBox.Show(erro.ToString(), "Erro Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        public static void InformarErro(Exception erro)
        {
            MessageBox.Show(erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

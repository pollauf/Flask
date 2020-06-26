using Flask.TELAS.METODOS;
using Flask.TELAS.METODOS.EXTENSORES;
using FlaskMODEL;
using FlaskMODEL.CONSULTAS;
using FlaskUI;
using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.Reagentes
{
    public partial class FrmCadastroReagente : FlaskForm
    {
        Reagente model;
        public FrmCadastroReagente()
        {
            InitializeComponent();
        }

        private void flaskTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlaskSearchButton1_Click(object sender, EventArgs e)
        {
            int id = Tela.ConsultaGeral(new ConsultaReagente());
            if (id != -1)
            {
                txtID.Text = id.ToString();
                TxtID_Leave(null, new EventArgs());
            }
        }

        private void FrmCadastroReagente_Load(object sender, EventArgs e)
        {
            model = new Reagente();
            txtTipo.Carregar(Metodos.EnumToList<TipoReagente>());
            txtForca.Carregar(Metodos.EnumToList<ForcaReagente>());
            txtComboConcentracao.Carregar(Metodos.EnumToList<Concentracao>());
            AtualizarControlesConstanteIonizacao();
        }

        private void flaskGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlaskComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarControlesConstanteIonizacao();
        }

        private void RbClasseMono_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarControlesConstanteIonizacao();
        }

        private void AtualizarControlesConstanteIonizacao()
        {
            var forcaReagente = (ForcaReagente)txtForca.SelectedIndex;

            if (forcaReagente == ForcaReagente.Desconhecida || forcaReagente == ForcaReagente.Forte)
            {
                flaskGroupBox2.Visible = false;
                return;
            }

            flaskGroupBox2.Visible = true;

            if (rbClasseMono.Checked || rbClasseDesconhecida.Checked)
            {
                pnlK1.Visible = true;
                pnlK2.Visible = pnlK3.Visible = pnlK4.Visible = false;
            }
            else if (rbClasseDi.Checked)
            {
                pnlK1.Visible = pnlK2.Visible = true;
                pnlK3.Visible = pnlK4.Visible = false;
            }
            else if (rbClasseTri.Checked)
            {
                pnlK1.Visible = pnlK2.Visible = pnlK3.Visible = true;
                pnlK4.Visible = false;
            }
            else if (rbClasseTetra.Checked)
            {
                pnlK1.Visible = pnlK2.Visible = pnlK3.Visible = pnlK4.Visible = true;
            }

            var controlesFlowLayoutPanel = new List<Control>();

            foreach (Control item in panel1.Controls)
                if (item.Visible)
                    controlesFlowLayoutPanel.Add(item);

            controlesFlowLayoutPanel = controlesFlowLayoutPanel.OrderBy(x => x.Name).ToList();

            for (int i = 0; i < controlesFlowLayoutPanel.Count; i++)
                controlesFlowLayoutPanel[i].Location = new Point(pnlK1.Width * i, 0);

        }

        private void ComboConcentracao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Concentracao)txtComboConcentracao.SelectedIndex) == Concentracao.Conhecida)
            {
                lblMols.Visible = txtConcentracao.Visible = true;
                txtConcentracao.CampoObrigatorio = true;
            }
            else
            {
                lblMols.Visible = txtConcentracao.Visible = false;
                txtConcentracao.Text = string.Empty;
                txtConcentracao.CampoObrigatorio = false;
            }
        }

        private void FlaskButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.VerificarCamposObrigatorios())
                    return;

                if (!ValidarInformacoes())
                    return;

                using (FlaskDatabase db = new FlaskDatabase())
                {
                    model.Nome = txtNome.Text;
                    model.Descricao = txtDescricao.Text;
                    model.Tipo = (TipoReagente)txtTipo.SelectedIndex;

                    var classeSelecionada = ClasseReagente.Desconhecida;
                    if (rbClasseDesconhecida.Checked)
                        classeSelecionada = ClasseReagente.Desconhecida;
                    else if (rbClasseMono.Checked)
                        classeSelecionada = ClasseReagente.Mono;
                    else if (rbClasseDi.Checked)
                        classeSelecionada = ClasseReagente.Di;
                    else if (rbClasseTri.Checked)
                        classeSelecionada = ClasseReagente.Tri;
                    else if (rbClasseTetra.Checked)
                        classeSelecionada = ClasseReagente.Tetra;

                    model.Classe = classeSelecionada;
                    model.Forca = (ForcaReagente)txtForca.SelectedIndex;
                    model.Concentracao = string.IsNullOrEmpty(txtConcentracao.Text) ? 0 : double.Parse(txtConcentracao.Text);

                    model.KI1 = string.IsNullOrEmpty(txtK1.Text) ? 0 : double.Parse(txtK1.Text);
                    model.KI2 = string.IsNullOrEmpty(txtK2.Text) ? 0 : double.Parse(txtK2.Text);
                    model.KI3 = string.IsNullOrEmpty(txtK3.Text) ? 0 : double.Parse(txtK3.Text);
                    model.KI4 = string.IsNullOrEmpty(txtK4.Text) ? 0 : double.Parse(txtK4.Text);

                    if (Modo == Modo.Novo)
                    {
                        int? nextID = db.Reagente.OrderByDescending(x => x.ID).FirstOrDefault().ID;
                        model.ID = nextID == null ? 1 : nextID.Value + 1;

                        db.Entry(model).State = EntityState.Added;
                        db.Reagente.Add(model);
                    }
                    else if (Modo == Modo.Alteracao)
                    {
                        db.Entry(model).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                    Tela.InformarSalvoSucesso();
                    txtID.Select();

                    Modo = Modo.Alteracao;
                    txtID.Text = model.ID.ToString("000000");
                }
            }
            catch (Exception ex)
            {
                Tela.InformarErroFatal(ex);
            }
        }

        private bool ValidarInformacoes()
        {
            var forcaReagente = (ForcaReagente)txtForca.SelectedIndex;

            if (forcaReagente == ForcaReagente.Desconhecida || forcaReagente == ForcaReagente.Forte)
            {
                txtK1.Text = txtK2.Text = txtK3.Text = txtK4.Text = string.Empty;
            }
            else if (rbClasseDesconhecida.Checked || rbClasseMono.Checked)
            {
                txtK2.Text = txtK3.Text = txtK4.Text = string.Empty;
            }
            else if (rbClasseDi.Checked)
            {
                txtK3.Text = txtK4.Text = string.Empty;
            }
            else if (rbClasseTri.Checked)
            {
                txtK4.Text = string.Empty;
            }

            if (((Concentracao)txtComboConcentracao.SelectedIndex) == Concentracao.Desconhecida)
            {
                txtConcentracao.Text = string.Empty;
            }

            return true;
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
                    var query = db.Reagente.Where(x => x.ID == id).FirstOrDefault();

                    if (query == null)
                    {
                        Limpar(null, new EventArgs());
                        return;
                    }                        

                    model = query;

                    txtID.Text = model.ID.ToString("000000");
                    txtID.Ativo = false;
                    txtNome.Text = model.Nome;
                    txtDescricao.Text = model.Descricao;

                    if (model.Concentracao > 0)
                    {
                        txtComboConcentracao.SelectedIndex = (int)Concentracao.Conhecida;
                        txtConcentracao.Text = model.Concentracao.FormatarString();
                    }

                    txtTipo.SelectedIndex = (int)model.Tipo;
                    txtForca.SelectedIndex = (int)model.Forca;

                    if (model.Classe == ClasseReagente.Desconhecida)
                        rbClasseDesconhecida.Checked = true;
                    else if (model.Classe == ClasseReagente.Mono)
                        rbClasseMono.Checked = true;
                    else if (model.Classe == ClasseReagente.Di)
                        rbClasseDi.Checked = true;
                    else if (model.Classe == ClasseReagente.Tri)
                        rbClasseTri.Checked = true;
                    else if (model.Classe == ClasseReagente.Tetra)
                        rbClasseTetra.Checked = true;

                    txtK1.Text = model.KI1 == 0 ? string.Empty : model.KI1.FormatarString();
                    txtK2.Text = model.KI2 == 0 ? string.Empty : model.KI2.FormatarString();
                    txtK3.Text = model.KI3 == 0 ? string.Empty : model.KI3.FormatarString();
                    txtK4.Text = model.KI4 == 0 ? string.Empty : model.KI4.FormatarString();

                    Modo = Modo.Alteracao;
                    txtNome.Select();
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
            this.LimparCampos();

            txtID.Ativo = true;
            txtComboConcentracao.SelectedIndex = (int)Concentracao.Desconhecida;
            txtTipo.SelectedIndex = (int)TipoReagente.Acido;
            txtForca.SelectedIndex = (int)ForcaReagente.Desconhecida;
            rbClasseDesconhecida.Checked = true;
            tabControl1.SelectedIndex = 0;

            txtID.Select();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modo != Modo.Alteracao)
                    return;

                if (!Tela.PerguntarDesejaExcluir())
                    return;

                using (FlaskDatabase db = new FlaskDatabase())
                {
                    db.Entry(model).State = EntityState.Deleted;
                    db.SaveChanges();
                }

                Tela.InformarExcluidoSucesso();
                Limpar(null, new EventArgs());
            }
            catch (Exception ex)
            {
                Tela.InformarErroFatal(ex);
            }
        }
    }
}

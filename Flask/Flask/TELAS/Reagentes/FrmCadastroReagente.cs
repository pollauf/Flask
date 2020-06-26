using Flask.TELAS.METODOS;
using Flask.TELAS.METODOS.EXTENSORES;
using FlaskMODEL;
using FlaskMODEL.CONSULTAS;
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

        private void flaskSearchButton1_Click(object sender, EventArgs e)
        {
            Tela.ConsultaGeral(new ConsultaReagente());
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

                model.Valencia = classeSelecionada;
                model.Forca = (ForcaReagente)txtForca.SelectedIndex;
                model.Concentracao = string.IsNullOrEmpty(txtConcentracao.Text) ? 0 : double.Parse(txtConcentracao.Text);

                model.KI1 = string.IsNullOrEmpty(txtK1.Text) ? 0 : double.Parse(txtK1.Text);
                model.KI2 = string.IsNullOrEmpty(txtK2.Text) ? 0 : double.Parse(txtK2.Text);
                model.KI3 = string.IsNullOrEmpty(txtK3.Text) ? 0 : double.Parse(txtK3.Text);
                model.KI4 = string.IsNullOrEmpty(txtK4.Text) ? 0 : double.Parse(txtK4.Text);               
                
                if (model.ID == 0)
                {
                    model.ID = 2;
                    db.Reagente.Add(model);                    
                }

                db.SaveChanges();
            }

            this.LimparCampos();
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
    }
}

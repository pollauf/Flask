using Flask.TELAS.METODOS;
using FlaskMODEL;
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
        public FrmCadastroReagente()
        {
            InitializeComponent();
        }

        private void flaskTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void flaskSearchButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroReagente_Load(object sender, EventArgs e)
        {
            flaskComboBox1.Carregar(Extensao.EnumToList<TipoReagente>());
            flaskComboBox2.Carregar(Extensao.EnumToList<ForcaReagente>());
            comboConcentracao.Carregar(Extensao.EnumToList<Concentracao>());
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
            var forcaReagente = (ForcaReagente)flaskComboBox2.SelectedIndex;

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
            if (((Concentracao)comboConcentracao.SelectedIndex) == Concentracao.Conhecida)
            {
                lblMols.Visible = txtConcentracao.Visible = true;
            }
            else
            {
                lblMols.Visible = txtConcentracao.Visible = false;
                txtConcentracao.Text = string.Empty;
            }
        }
    }
}

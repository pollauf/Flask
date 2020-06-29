using FlaskUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.Analises
{
    public partial class FrmPotenciometrica : FlaskForm
    {
        private List<Potenciometrica> titulacao;
        public List<Potenciometrica> Titulacao
        {
            get { return titulacao; }
            set
            {
                titulacao = value;
            }
        }

        public FrmPotenciometrica()
        {
            InitializeComponent();            
            Titulacao = new List<Potenciometrica>();                       
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            double volume = 0;
            double pH = 0;

            if (!double.TryParse(txtVolume.Text, out volume))
                return;

            if (!double.TryParse(txtpH.Text, out pH))
                return;

            double volumeAdicionado = volume;
            if (Titulacao.Count > 0)
                volumeAdicionado += Titulacao[Titulacao.Count - 1].Volume;

            var potenciometria = new Potenciometrica(volumeAdicionado, pH);
            Titulacao.Add(potenciometria);
            txtpH.Text = string.Empty;
            txtpH.Select();
            flaskDataGridView1.Rows.Add(volumeAdicionado, pH);
            chart1.Series[0].Points.AddXY(volumeAdicionado, pH);
        }

        private void TxtpH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnAdicionar_Click(null, new EventArgs());
        }

        private void FrmPotenciometrica_Load(object sender, EventArgs e)
        {

        }

        private void RemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flaskDataGridView1.SelectedRows[0].Index < 0)
                return;

            int index = flaskDataGridView1.SelectedRows[0].Index;

            flaskDataGridView1.Rows.RemoveAt(index);
            chart1.Series[0].Points.RemoveAt(index);
            Titulacao.RemoveAt(index);
        }
    }
}

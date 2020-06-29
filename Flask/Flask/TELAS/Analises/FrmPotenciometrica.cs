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
using System.Threading;
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
        public FrmPotenciometrica(Reagente reagente)
        {
            InitializeComponent();
            Titulacao = new List<Potenciometrica>();
            UcTitulado.Reagente = reagente;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!btnAdicionar.Visible)
                return;

            double volume = 0;
            double pH = 0;

            if (!double.TryParse(txtVolume.Text, out volume))
                return;

            if (!double.TryParse(txtpH.Text, out pH))
                return;

            volume = Math.Round(volume, 5);
            pH = Math.Round(pH, 5);

            double volumeAdicionado = volume;
            if (Titulacao.Count > 0)
                volumeAdicionado += Titulacao[Titulacao.Count - 1].Volume;

            var potenciometria = new Potenciometrica(volumeAdicionado, pH);
            Titulacao.Add(potenciometria);
            txtpH.Text = string.Empty;
            txtpH.Select();
            flaskDataGridView1.Rows.Add(volumeAdicionado.FormatarString(), pH.FormatarString());
            chart1.Series[0].Points.AddXY(volumeAdicionado, pH);
        }

        private async void TxtpH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdicionar_Click(null, new EventArgs());
            }

            await Task.Run(() => Thread.Sleep(100));
            txtpH.Select();
        }

        private void FrmPotenciometrica_Load(object sender, EventArgs e)
        {
            AtualizarFiltros();
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

        private void TxtVolume_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
                txtpH.Select();*/
        }

        private void UcTitulante_ReagenteChanged(object sender, EventArgs e)
        {
            AtualizarFiltros();

            if (UcTitulado.Reagente != null && UcTitulante.Reagente != null)
            {
                txtVolume.Ativo = txtpH.Ativo = btnAdicionar.Visible = true;
            }
            else
            {
                txtVolume.Ativo = txtpH.Ativo = btnAdicionar.Visible = false;
            }
        }
        private void LimparTudo()
        {
            this.LimparCampos();
            flaskDataGridView1.Rows.Clear();
            titulacao.Clear();
            chart1.Series[0].Points.Clear();
        }

        private void AtualizarFiltros()
        {
            var tipoTitulante = TipoReagente.Anfotero;
            var tipoTitulado = TipoReagente.Anfotero;

            if (UcTitulado.Reagente != null)
                tipoTitulante = UcTitulado.Reagente.Tipo.RetornarReagenteOposto();

            if (UcTitulante.Reagente != null)
                tipoTitulado = UcTitulante.Reagente.Tipo.RetornarReagenteOposto();

            UcTitulante.Consulta = new ConsultaReagenteTitulacao(tipoTitulante, true, true);
            UcTitulado.Consulta = new ConsultaReagenteTitulacao(tipoTitulado, false);

            LimparTudo();
            txtVolume.Select();
        }

        private void BtnSalvarGrafico_Click(object sender, EventArgs e)
        {
            if (Titulacao.Count == 0 || UcTitulante.Reagente == null || UcTitulado.Reagente == null)
            {
                MessageBox.Show("Há campos sem preenchimento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var model = new Potenciometria();

            string grafico = Titulacao.GerarString();
            string titulante = UcTitulante.Reagente.ResumirInformacoes();
            int titulado = UcTitulado.Reagente.ID;

            model.TituladoID = titulado;
            model.DescricaoTitulante = titulante;
            model.Valores = grafico;

            model.Salvar();

            LimparTudo();
        }
    }
}

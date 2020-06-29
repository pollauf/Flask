using FlaskMODEL.CONSULTAS;
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

namespace Flask.TELAS
{
    public partial class FrmConsultaGeral : FlaskForm
    {
        public int ID { get; set; }
        public FrmConsultaGeral(string nomeConsulta, object dataSource)
        {
            InitializeComponent();
            ucHeader1.Titulo = nomeConsulta;
            flaskDataGridView1.DataSource = dataSource;
        }
        public FrmConsultaGeral(string nomeConsulta, object dataSource, List<ConfiguracaoCabecalho> cabecalhos)
        {
            InitializeComponent();
            ucHeader1.Titulo = nomeConsulta;
            flaskDataGridView1.DataSource = dataSource;

            if (cabecalhos.Count > 0)
            {
                for (int i = 0; i < flaskDataGridView1.Columns.Count; i++)
                {
                    flaskDataGridView1.Columns[i].HeaderText = cabecalhos[i].Nome;
                    flaskDataGridView1.Columns[i].DefaultCellStyle.Alignment = cabecalhos[i].Alinhamento;
                }
            }
        }

        private void AjustarTamanho()
        {
            var somaLarguras = 6;
            var somaAltura = 105 + flaskDataGridView1.Rows.Count * 22;
            somaAltura = somaAltura > 450 ? 450 : somaAltura;

            var colunas = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn item in flaskDataGridView1.Columns)
            {
                colunas.Add(item);
                somaLarguras += item.Width;
            }

            colunas.OrderByDescending(x => x.Width).FirstOrDefault().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.Width = somaLarguras;
            this.Height = somaAltura;
        }

        private void FrmConsultaGeral_Load(object sender, EventArgs e)
        {
            ID = -1;
            AjustarTamanho();
            flaskDataGridView1.Select();
        }

        private void FlaskButton1_Click(object sender, EventArgs e)
        {
            if (flaskDataGridView1.SelectedRows[0].Index == -1)
                return;

            ID = (int)flaskDataGridView1.SelectedRows[0].Cells[0].Value;
            Close();
        }

        private void FlaskDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FlaskButton1_Click(null, new EventArgs());
        }

        private void FlaskDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                FlaskButton1_Click(null, new EventArgs());
        }

        private void FrmConsultaGeral_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
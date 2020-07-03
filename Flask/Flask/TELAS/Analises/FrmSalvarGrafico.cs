using Flask.TELAS.METODOS;
using FlaskMODEL.TABELAS;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Flask.TELAS.Analises
{
    public partial class FrmSalvarGrafico : FlaskForm
    {
        public FrmSalvarGrafico(Potenciometria potenciometria)
        {
            InitializeComponent();

            var lista = new List<Potenciometrica>();
            lista = lista.GerarLista(potenciometria.Valores);

            CarregarLista(lista);
        }
        public FrmSalvarGrafico(List<Potenciometrica> lista)
        {
            InitializeComponent();

            CarregarLista(lista);
        }
        public void CarregarLista(List<Potenciometrica> lista)
        {
            foreach (var item in lista)
            {
                chart1.Series[0].Points.AddXY(item.Volume, item.pH);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "Arquivo de Imagem (*.png)|*.png";

                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.FileName = $"Potenciometria_{DateTime.Now.FormatarDataParaStringDeArquivo()}.png";

                dialog.Title = "Salvar Gráfico";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    chart1.SaveImage(dialog.FileName, ChartImageFormat.Png);
                    Tela.InformarSalvoSucesso();
                }
            }
            catch (Exception ex)
            {
                Tela.InformarErro(ex);
            }
        }

        private void FrmSalvarGrafico_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Title = "Volume (mL)";
            chart1.ChartAreas[0].AxisY.Title = "pH";

            chart1.ChartAreas[0].AxisX.TitleFont =
                chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}

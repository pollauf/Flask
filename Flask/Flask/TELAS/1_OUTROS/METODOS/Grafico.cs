using Flask.TELAS.Analises;
using FlaskMODEL.TABELAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Flask
{
    public class Grafico
    {
        public Chart GraficoAtual { get; private set; }
        public void InicializarGrafico(Chart graficoPotenciometria)
        {
            GraficoAtual = graficoPotenciometria;

            var tooltip = new ToolTip();
            tooltip.SetToolTip(GraficoAtual, "Expandir Gráfico");
            GraficoAtual.Click += ExpandirGrafico;
            GraficoAtual.Cursor = Cursors.Hand;
        }

        public void AdicionarTagGrafico(object tag)
        {
            GraficoAtual.Tag = tag;
        }

        public void ExpandirGrafico(object sender, EventArgs e)
        {
            if (GraficoAtual.Series[0].Points.Count > 0)
            {
                object tag = GraficoAtual.Tag;

                var frm = new Form();
                
                if (tag is Potenciometria)
                    frm = new FrmSalvarGrafico((Potenciometria)tag);
                else if (tag is List<Potenciometrica>)
                    frm = new FrmSalvarGrafico((List<Potenciometrica>)tag);

                frm.ShowDialog();
            }
            else
                MessageBox.Show("Não há dados no gráfico!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

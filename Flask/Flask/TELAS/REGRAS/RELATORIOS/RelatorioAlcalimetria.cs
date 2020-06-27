using FlaskMODEL;
using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public class RelatorioAlcalimetria : IRelatorioTitulacao
    {
        public Reagente Titulante { get; set; }
        public Reagente Titulado { get; set; }
        public List<ResultadoTitulacao> Replicatas { get; set; }
        public double Resultado { get; set; }
        public RelatorioAlcalimetria(Reagente titulante, Reagente titulado, List<ResultadoTitulacao> replicatas, double resultado)
        {
            Titulante = titulante;
            Titulado = titulado;
            Replicatas = replicatas;
            Resultado = resultado;
        }
        public string GerarRelatorio()
        {
            var relatorio =
                $"ANÁLISE DE ALCALIMETRIA\n\nResultado: {this.Resultado.FormatarString()} mol/L\n\n" +
                $"TITULANTE:\n{this.Titulante.ResumirInformacoes()}\n\n" +
                $"TITULADO:\n{this.Titulado.ResumirInformacoes()}\n\n" +
                $"REPLICATAS:\n@REPLICATAS";

            var replicatas = string.Empty;

            foreach (ResultadoTitulacao item in this.Replicatas)
            {
                replicatas +=
                    $"Volume de Titulado Utilizado: {item.VolumeTitulado.FormatarString()} mL\n" +
                     $"Volume de Titulante Gasto: {item.VolumeTitulante.FormatarString()} mL\n" +
                      $"Resultado: {item.Resultado.FormatarString()} mol/L\n\n";
            }

            relatorio = relatorio.Replace("@REPLICATAS", replicatas);

            return relatorio;
        }
    }
}

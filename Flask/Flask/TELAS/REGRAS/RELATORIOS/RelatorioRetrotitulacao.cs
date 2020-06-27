using FlaskMODEL;
using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public class RelatorioRetrotitulacao : IRelatorioTitulacao, IAnalitoExcesso
    {
        public IRelatorioTitulacao RelatorioTitulacaoExcesso { get; set; }
        public Reagente ReagenteExcesso { get; set; }
        public Reagente Analito { get; set; }
        public double Resultado { get; set; }
        public RelatorioRetrotitulacao(IRelatorioTitulacao relatorioTitulacaoExcesso, Reagente reagenteExcesso, Reagente analito, double resultado)
        {
            RelatorioTitulacaoExcesso = relatorioTitulacaoExcesso;
            ReagenteExcesso = reagenteExcesso;
            Analito = analito;
            Resultado = resultado;
        }
        public string GerarRelatorio()
        {
            var RelatorioReagentesExcesso = (ITitulanteTitulado)RelatorioTitulacaoExcesso;
            var RelatorioReplicatas = (IReplicatas)RelatorioTitulacaoExcesso;

            var relatorio =
                $"ANÁLISE DE RETROTITULAÇÃO\n\nResultado: {this.Resultado.FormatarString()} mol/L\n\n" +
                $"EXCESSO:\n{this.ReagenteExcesso.ResumirInformacoes()}\n\n" +
                $"ANALITO:\n{this.Analito.ResumirInformacoes()}\n\n" +
                "______________________________________________________________" +
                $"TITULAÇÃO DO EXCESSO\n\nResultado:{RelatorioTitulacaoExcesso.Resultado.FormatarString()}\n\n" +
                $"TITULANTE:\n{RelatorioReagentesExcesso.Titulante.ResumirInformacoes()}\n\n" +
                $"TITULADO:\n{RelatorioReagentesExcesso.Titulado.ResumirInformacoes()}\n\n" +
                $"REPLICATAS:\n@REPLICATAS";

            var replicatas = string.Empty;

            foreach (ResultadoTitulacao item in RelatorioReplicatas.Replicatas)
            {
                replicatas +=
                    $"Volume de Titulado Utilizado: {item.VolumeTitulado.FormatarString()} mL\n" +
                     $"Volume de Titulante Gasto: {item.VolumeTitulante.FormatarString()} mL\n" +
                      $"Resultado: {item.ConcentracaoTitulado.FormatarString()} mol/L\n\n";
            }

            relatorio = relatorio.Replace("@REPLICATAS", replicatas);

            return relatorio;
        }
    }
}

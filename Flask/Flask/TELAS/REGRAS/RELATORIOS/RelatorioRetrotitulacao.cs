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
        public double ConcentracaoTitulado { get; set; }
        public RelatorioRetrotitulacao(IRelatorioTitulacao relatorioTitulacaoExcesso, Reagente reagenteExcesso, Reagente analito, double resultado)
        {
            RelatorioTitulacaoExcesso = relatorioTitulacaoExcesso;
            ReagenteExcesso = reagenteExcesso;
            Analito = analito;
            ConcentracaoTitulado = resultado;
        }
        public string GerarRelatorio()
        {
            var RelatorioReagentesExcesso = (ITitulanteTitulado)RelatorioTitulacaoExcesso;
            var RelatorioReplicatas = (IReplicatas)RelatorioTitulacaoExcesso;

            var relatorio =
                $"ANÁLISE DE RETROTITULAÇÃO\n\nResultado: {this.ConcentracaoTitulado.FormatarString()} mol/L\n\n" +
                $"EXCESSO:\n{this.ReagenteExcesso.ResumirInformacoes()}\n\n" +
                $"ANALITO:\n{this.Analito.ResumirInformacoes()}\n\n" +
                "______________________________________________________________\n" +
                $"TITULAÇÃO DO EXCESSO\n\nResultado: {RelatorioTitulacaoExcesso.ConcentracaoTitulado.FormatarString()} mol/L\n\n" +
                $"TITULANTE:\n{RelatorioReagentesExcesso.Titulante.ResumirInformacoes()}\n\n" +
                $"TITULADO:\n{RelatorioReagentesExcesso.Titulado.ResumirInformacoes()}\n\n" +
                $"REPLICATAS:\n@REPLICATAS";

            var replicatas = string.Empty;

            foreach (ResultadoTitulacao item in RelatorioReplicatas.Replicatas)
            {
                replicatas +=
                    $"Volume de Titulante: {item.VolumeTitulante.FormatarString()} mL\n" +
                    $"Volume de Excesso: {item.VolumeTitulado.FormatarString()} mL\n\n";                     
            }

            relatorio = relatorio.Replace("@REPLICATAS", replicatas);

            return relatorio;
        }
    }
}

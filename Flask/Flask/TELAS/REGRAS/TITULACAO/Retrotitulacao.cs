using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask
{
    public class Retrotitulacao : IAnalitoExcesso
    {
        public ITitulanteTitulado ReagentesTitulacaoDoExcesso { get; set; }
        public Reagente ReagenteExcesso { get; set; }
        public Reagente Analito { get; set; }
        public Retrotitulacao(ITitulanteTitulado reagentesTitulacaoDoExcesso, Reagente reagenteExcesso, Reagente analito)
        {
            ReagentesTitulacaoDoExcesso = reagentesTitulacaoDoExcesso;
            ReagenteExcesso = reagenteExcesso;
            Analito = analito;
        }
        public double CalcularConcentracao(double volumeTotalDeExcesso, double volumeDeAnalito, double volumeExcessoReagido)//double volumeTitulanteGasto)
        {
            //double volumeExcessoRestante = (volumeTitulanteGasto * ReagentesTitulacaoDoExcesso.Titulante.Concentracao) / ReagenteExcesso.Concentracao;
            //double volumeExcessoReagido = volumeTotalDeExcesso - volumeExcessoRestante;
            double concentracaoAnalito = 
                ((int)Analito.Classe * volumeExcessoReagido * ReagenteExcesso.Concentracao) / (volumeDeAnalito * (int)ReagenteExcesso.Classe);

            return concentracaoAnalito;
        }
    }
}

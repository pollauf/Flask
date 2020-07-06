using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public class Titulacao : ITitulacao, ITitulanteTitulado
    {
        public Reagente Titulante { get; set; }
        public Reagente Titulado { get; set; }
        public double CalcularConcentracao(double volumeDeTitulado, double volumeDeTitulante)
        {
            double concentracaoTitulado = 0;
            double concentracaoTitulante = Titulante.Concentracao;

            var nTitulado = (int)Titulado.Classe;
            var nTitulante = (int)Titulante.Classe;

            concentracaoTitulado = (nTitulante * concentracaoTitulante * volumeDeTitulante) / (nTitulado * volumeDeTitulado);

            return concentracaoTitulado;
        }
    }
}

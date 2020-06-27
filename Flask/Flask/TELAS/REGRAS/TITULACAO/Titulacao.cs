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
            double m1 = 0;
            double m2 = Titulante.Concentracao;

            var n1 = (int)Titulado.Classe;
            var n2 = (int)Titulante.Classe;

            var v1 = volumeDeTitulado;
            var v2 = volumeDeTitulante;

            m1 = (n1 * m2 * v2) / (n2 * v1);

            return m1;
        }
    }
}

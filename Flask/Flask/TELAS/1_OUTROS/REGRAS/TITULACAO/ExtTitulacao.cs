using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public static class ExtTitulacao
    {
        public static double CalcularVolumeTitulado(this ITitulacao titulacao, double volumeDeTitulante)
        {
            var titulante = ((ITitulanteTitulado)titulacao).Titulante;
            var titulado = ((ITitulanteTitulado)titulacao).Titulado;

            double concentracaoTitulado = titulado.Concentracao;
            double concentracaoTitulante = titulante.Concentracao;

            var nTitulado = (int)titulado.Classe;
            var nTitulante = (int)titulante.Classe;

            double volumeDeTitulado =
                (nTitulante * concentracaoTitulante * volumeDeTitulante) / (nTitulado * concentracaoTitulado);

            return volumeDeTitulado;
        }
    }
}

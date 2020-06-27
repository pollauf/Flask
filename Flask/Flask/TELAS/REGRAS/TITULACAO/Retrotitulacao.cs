using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public class Retrotitulacao
    {
        public IRelatorioTitulacao RelatorioTitulacaoExcesso { get; set; }
        public Reagente ReagenteExcesso { get; set; }
        public Reagente Analito { get; set; }

        public double Calcular()
        {
            return 10;
        }
    }
}

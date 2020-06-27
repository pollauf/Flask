using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public class ResultadoTitulacao
    {
        public double VolumeTitulado { get; set; }
        public double VolumeTitulante { get; set; }
        public double Resultado { get; set; }
        public ResultadoTitulacao(double volumeTitulado, double volumeTitulante, double resultado)
        {
            VolumeTitulado = volumeTitulado;
            VolumeTitulante = volumeTitulante;
            Resultado = resultado;
        }
    }
}

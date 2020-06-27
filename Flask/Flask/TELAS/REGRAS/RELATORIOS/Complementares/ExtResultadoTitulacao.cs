using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public static class ExtResultadoTitulacao
    {
        public static double CalcularMediaVolumeTitulado(this List<ResultadoTitulacao> resultadoTitulacoes)
        {
            var resultados = new List<double>();

            foreach (ResultadoTitulacao item in resultadoTitulacoes)
                resultados.Add(item.VolumeTitulado);

            double media = resultados.Average();
            media = Math.Round(media, 5);

            return media;
        }

        public static double CalcularMediaVolumeTitulante(this List<ResultadoTitulacao> resultadoTitulacoes)
        {
            var resultados = new List<double>();

            foreach (ResultadoTitulacao item in resultadoTitulacoes)
                resultados.Add(item.VolumeTitulante);

            double media = resultados.Average();
            media = Math.Round(media, 5);

            return media;
        }
    }
}

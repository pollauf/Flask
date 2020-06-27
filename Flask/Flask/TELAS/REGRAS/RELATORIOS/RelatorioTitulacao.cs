using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public class RelatorioTitulacao : IRelatorioTitulacao
    {
        public Reagente Titulante { get; set; }
        public Reagente Titulado { get; set; }
        public List<ResultadoTitulacao> Replicatas { get; set; }
        public double Resultado { get; set; }
        public RelatorioTitulacao(Reagente titulante, Reagente titulado, List<ResultadoTitulacao> replicatas, double resultado)
        {
            Titulante = titulante;
            Titulado = titulado;
            Replicatas = replicatas;
            Resultado = resultado;
        }
    }
}

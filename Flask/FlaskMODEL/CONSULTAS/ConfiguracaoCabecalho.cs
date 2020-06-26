using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL.CONSULTAS
{
    public class ConfiguracaoCabecalho
    {
        public string Nome { get; set; } = string.Empty;
        public Alinhamento Alinhamento { get; set; } = Alinhamento.Esquerda;
    }
}

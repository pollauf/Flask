using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskMODEL.CONSULTAS
{
    public class ConfiguracaoCabecalho
    {
        public string Nome { get; set; } = string.Empty;
        public DataGridViewContentAlignment Alinhamento { get; set; }
        public ConfiguracaoCabecalho(string nome, DataGridViewContentAlignment alinhamento = DataGridViewContentAlignment.MiddleLeft)
        {
            Nome = nome;
            Alinhamento = alinhamento;
        }
    }
}

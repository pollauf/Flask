using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL.CONSULTAS
{
    public interface IConsulta
    {
        string Nome { get; set; }
        List<ConfiguracaoCabecalho> Cabecalhos { get; set; }
        object Pesquisar();
    }
}

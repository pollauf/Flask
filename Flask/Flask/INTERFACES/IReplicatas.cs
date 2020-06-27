using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public interface IReplicatas
    {
        List<ResultadoTitulacao> Replicatas { get; set; }        
    }
}

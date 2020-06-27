using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public interface ITitulanteTitulado
    {
        Reagente Titulante { get; set; }
        Reagente Titulado { get; set; }
    }
}

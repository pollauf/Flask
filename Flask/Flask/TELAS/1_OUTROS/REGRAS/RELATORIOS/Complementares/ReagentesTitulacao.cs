using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public class ReagentesTitulacao : ITitulanteTitulado
    {
        public Reagente Titulante { get; set; }
        public Reagente Titulado { get; set; }
    }
}

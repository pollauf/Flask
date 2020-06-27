using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public interface IAnalitoExcesso
    {
        Reagente ReagenteExcesso { get; set; }
        Reagente Analito { get; set; }
    }
}

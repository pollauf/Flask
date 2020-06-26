using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public interface ITitulacao
    {
        Reagente Titulante { get; set; }
        Reagente Titulado { get; set; }
        double ObterResultado(double volumeDeTitulado, double volumeDeTitulante);
    }
}

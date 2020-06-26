using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL
{
    public enum AbasMenu
    {
        Oculto = 0,
        Reagentes = 1,
        Analises = 2,
        Relatorios = 3,
        Sobre = 4,
    }

    public enum Verdade
    {
        [Description("Não")]
        Nao = 0,
        Sim = 1
    }
}

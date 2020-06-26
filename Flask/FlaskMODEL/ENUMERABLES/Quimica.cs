using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL
{
    public enum TipoReagente
    {
        [Description("Solução Ácida")]
        Acido = 0,
        [Description("Solução Básica")]
        Base = 1,
    }

    public enum Concentracao
    {
        Desconhecida = 0,
        Conhecida = 1,
    }

    public enum ForcaReagente
    {
        Desconhecida = 0,
        Fraca = 1,
        Forte = 2,
    }

    public enum ClasseReagente
    {
        Desconhecida = 0,
        Mono = 1,
        Di = 2,
        Tri = 3,
        Tetra = 4,
    }
}

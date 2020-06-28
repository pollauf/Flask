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
        [Description("Ácido")]
        Acido = 0,
        [Description("Base")]
        Base = 1,
        [Description("Anfótero")]
        Anfotero = 2,
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

    public enum TipoAnalise
    {
        Acidimetria = 0,
        Alcalimetria = 1,
        Retrotitulacao = 3,
    }
}

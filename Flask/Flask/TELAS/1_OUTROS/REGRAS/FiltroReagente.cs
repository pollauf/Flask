using FlaskMODEL;
using FlaskMODEL.CONSULTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public static class FiltroReagente
    {
        public static TipoReagente RetornarReagenteOposto(this TipoReagente tipoReagente)
        {
            if (tipoReagente == TipoReagente.Acido)
                return TipoReagente.Base;
            else if (tipoReagente == TipoReagente.Base)
                return TipoReagente.Acido;
            else
                return TipoReagente.Anfotero;
        }
    }
}

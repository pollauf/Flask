using FlaskMODEL;
using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public static class ExtReagente
    {
        public static string ResumirInformacoes(this Reagente reagente)
        {
            var tipoReagente = reagente.Tipo == TipoReagente.Acido ? "Ácido" : "Base";

            if (reagente.Forca != ForcaReagente.Desconhecida)
            {
                var forcaReagente = reagente.Forca == ForcaReagente.Forte ? "Forte" : "Fraco";

                if (reagente.Forca == ForcaReagente.Fraca && reagente.Tipo == TipoReagente.Base)
                    forcaReagente = "Fraca";

                tipoReagente = $"{tipoReagente} {forcaReagente}";
            }

            if (reagente.Tipo == TipoReagente.Anfotero)
                tipoReagente = "Anfótero";

            var classeReagente = string.Empty;

            if (reagente.Tipo == TipoReagente.Acido)
                classeReagente = "Perde ";
            else if (reagente.Tipo == TipoReagente.Base)
                classeReagente = "Recebe ";
            else if (reagente.Tipo == TipoReagente.Anfotero)
                classeReagente = "Perde/Recebe ";

            classeReagente += ((int)reagente.Classe).ToString() + " H⁺";

            return
                $"Nome: {reagente.Nome}\n" +
                $"Tipo: {tipoReagente} ({classeReagente})\n" +
                $"Concentração: {reagente.Concentracao.FormatarString()} mol/L";
        }
    }
}

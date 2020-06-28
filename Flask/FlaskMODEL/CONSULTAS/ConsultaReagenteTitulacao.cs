using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL.CONSULTAS
{
    public class ConsultaReagenteTitulacao : ConsultaReagente
    {
        public TipoReagente TipoReagente { get; set; }
        public bool Titulante { get; set; }
        public ConsultaReagenteTitulacao(TipoReagente tipoReagente, bool titulante)
        {
            TipoReagente = tipoReagente;
            Titulante = titulante;
        }
        public override object Pesquisar()
        {
            try
            {
                var _return = new List<SReagenteGrid>();

                using (FlaskDatabase db = new FlaskDatabase())
                {
                    var query = new List<Reagente>();

                    if (TipoReagente != TipoReagente.Anfotero)
                    {
                        query = db.Reagente.Where(x => x.Classe != ClasseReagente.Desconhecida && (x.Tipo == TipoReagente.Anfotero || x.Tipo == TipoReagente)).ToList();
                    }
                    else
                    {
                        query = db.Reagente.Where(x => x.Classe != ClasseReagente.Desconhecida).ToList();
                    }

                    if (Titulante)
                        query = query.Where(x => x.Concentracao != 0 && x.Forca == ForcaReagente.Forte).ToList();

                    if (query.Count == 0)
                        return null;

                    _return = OrganizarGrid(query);
                }

                return _return;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

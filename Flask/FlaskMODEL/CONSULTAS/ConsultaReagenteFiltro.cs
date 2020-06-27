using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL.CONSULTAS
{
    public class ConsultaReagenteFiltro : ConsultaReagente
    {

        public TipoReagente FiltroTipo { get; set; }
        public ForcaReagente FiltroForca { get; set; }
        public bool FiltrarTodosOsTipos { get; set; }
        public bool FiltrarForca { get; set; }
        public bool FiltroClasseConhecida { get; set; }
        public bool FiltroConcentracaoConhecida { get; set; }
        public ConsultaReagenteFiltro(bool filtrarTodosTipo, bool filtrarForca, bool filtroClasseConhecida, bool filtroConcentracaoConhecida, TipoReagente filtroTipo = TipoReagente.Acido, ForcaReagente filtroForca = ForcaReagente.Forte)
        {
            FiltrarTodosOsTipos = filtrarTodosTipo;
            FiltroTipo = filtroTipo;
            FiltroForca = filtroForca;
            FiltroClasseConhecida = filtroClasseConhecida;
            FiltroConcentracaoConhecida = filtroConcentracaoConhecida;
            FiltrarForca = filtrarForca;
        }
        public override object Pesquisar()
        {
            try
            {
                var _return = new List<SReagenteGrid>();

                using (FlaskDatabase db = new FlaskDatabase())
                {
                    var query = new List<Reagente>();

                    if (FiltrarTodosOsTipos)
                    {
                        if (FiltrarForca)
                            query = db.Reagente.Where(x => x.Forca == FiltroForca).OrderBy(x => x.ID).ToList();
                        else
                            query = db.Reagente.OrderBy(x => x.ID).ToList();
                    }
                    else
                    {
                        if (FiltrarForca)
                            query = db.Reagente.Where(x => x.Tipo == FiltroTipo && x.Forca == FiltroForca).OrderBy(x => x.ID).ToList();
                        else
                            query = db.Reagente.Where(x => x.Tipo == FiltroTipo).OrderBy(x => x.ID).ToList();
                    }

                    if (FiltroClasseConhecida)
                        query = query.Where(x => x.Classe != ClasseReagente.Desconhecida).ToList();

                    if (FiltroConcentracaoConhecida)
                        query = query.Where(x => x.Concentracao > 0).ToList();

                    if (query.Count == 0)
                        return null;

                    foreach (var item in query)
                    {
                        _return.Add(new SReagenteGrid
                        {
                            ID = item.ID,
                            Nome = item.Nome,
                            Classe = Metodos.ObterDescricao(item.Classe),
                            Concentracao = item.Concentracao == 0 ? "Desconhecida" : item.Concentracao.ToString("0.00000"),
                            Forca = Metodos.ObterDescricao(item.Forca),
                            Tipo = Metodos.ObterDescricao(item.Tipo),
                        });
                    }
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

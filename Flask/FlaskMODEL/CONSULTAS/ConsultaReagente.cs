using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskMODEL.CONSULTAS
{
    public class ConsultaReagente : IConsulta
    {
        public string Nome { get; set; } = "Consulta de Reagente";
        public List<ConfiguracaoCabecalho> Cabecalhos { get; set; }

        public ConsultaReagente()
        {
            Cabecalhos = new List<ConfiguracaoCabecalho>();
            Cabecalhos.Add(new ConfiguracaoCabecalho("ID", DataGridViewContentAlignment.MiddleCenter));
            Cabecalhos.Add(new ConfiguracaoCabecalho("Nome"));
            Cabecalhos.Add(new ConfiguracaoCabecalho("Tipo"));
            Cabecalhos.Add(new ConfiguracaoCabecalho("Força"));
            Cabecalhos.Add(new ConfiguracaoCabecalho("Classe"));
            Cabecalhos.Add(new ConfiguracaoCabecalho("Concentração (mol/L)", DataGridViewContentAlignment.MiddleRight));
        }
        public virtual object Pesquisar()
        {
            try
            {
                var _return = new List<SReagenteGrid>();

                using (FlaskDatabase db = new FlaskDatabase())
                {
                    var query = db.Reagente.OrderBy(x => x.ID).ToList();

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

    public class SReagenteGrid
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Forca { get; set; }
        public string Classe { get; set; }
        public string Concentracao { get; set; }
    }
}

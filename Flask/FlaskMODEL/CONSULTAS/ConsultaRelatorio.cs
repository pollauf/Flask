using FlaskMODEL.TABELAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskMODEL.CONSULTAS
{
    public class ConsultaRelatorio : IConsulta
    {
        public string Nome { get; set; } = "Consulta de Registro";
        public List<ConfiguracaoCabecalho> Cabecalhos { get; set; }

        public ConsultaRelatorio()
        {
            Cabecalhos = new List<ConfiguracaoCabecalho>();
            Cabecalhos.Add(new ConfiguracaoCabecalho("ID", DataGridViewContentAlignment.MiddleCenter));
            Cabecalhos.Add(new ConfiguracaoCabecalho("Análise"));
            Cabecalhos.Add(new ConfiguracaoCabecalho("Data", DataGridViewContentAlignment.MiddleRight));
        }
        public virtual object Pesquisar()
        {
            try
            {
                var _return = new List<SRelatorioGrid>();

                using (FlaskDatabase db = new FlaskDatabase())
                {
                    var query = db.Relatorio.OrderBy(x => x.ID).ToList();

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

        protected List<SRelatorioGrid> OrganizarGrid(List<Relatorio> query)
        {
            var _return = new List<SRelatorioGrid>();

            foreach (var item in query)
            {
                _return.Add(new SRelatorioGrid
                {
                    ID = item.ID,
                    Analise = item.Analise,
                    Data = item.Data,
                });
            }

            return _return;
        }
    }

    public class SRelatorioGrid
    {
        public int ID { get; set; }
        public string Analise { get; set; }
        public DateTime Data { get; set; }
    }
}

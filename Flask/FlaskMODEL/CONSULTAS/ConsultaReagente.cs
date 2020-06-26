using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL.CONSULTAS
{
    public class ConsultaReagente : IConsulta
    {
        public string Nome { get; set; } = "Consulta de Reagente";
        public List<ConfiguracaoCabecalho> Cabecalhos { get; set; }

        //public string Cabecalhos { get; set; } = "ID,Nome,Tipo,Força,Classe,Concentração (mol/L)";
        public ConsultaReagente()
        {
            Cabecalhos = new List<ConfiguracaoCabecalho>();
            Cabecalhos.Add(new ConfiguracaoCabecalho{ Nome = "ID", Alinhamento = Alinhamento.Centro });
            Cabecalhos.Add(new ConfiguracaoCabecalho { Nome = "Nome" });
            Cabecalhos.Add(new ConfiguracaoCabecalho { Nome = "Tipo", Alinhamento = Alinhamento.Centro });
            Cabecalhos.Add(new ConfiguracaoCabecalho { Nome = "Força", Alinhamento = Alinhamento.Centro });
            Cabecalhos.Add(new ConfiguracaoCabecalho { Nome = "Classe", Alinhamento = Alinhamento.Centro });
            Cabecalhos.Add(new ConfiguracaoCabecalho { Nome = "Concentração (mol/L)", Alinhamento = Alinhamento.Direita });
        }
        public object Pesquisar()
        {
            var _return = new List<SReagenteGrid>();

            using (FlaskDatabase db = new FlaskDatabase())
            {
                var query = db.Reagente.OrderBy(x => x.ID).ToList();

                foreach (var item in query)
                {
                    _return.Add(new SReagenteGrid
                    {
                        ID = item.ID,
                        Nome = item.Nome,
                        Classe = Metodos.ObterDescricao(item.Valencia),
                        Concentracao = item.Concentracao == 0 ? "Desconhecida" : item.Concentracao.ToString("0.00000"),
                        Forca = Metodos.ObterDescricao(item.Forca),
                        Tipo = Metodos.ObterDescricao(item.Tipo),
                    });
                }
            }

            return _return;
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

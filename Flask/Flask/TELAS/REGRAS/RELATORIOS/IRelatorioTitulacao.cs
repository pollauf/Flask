using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public interface IRelatorioTitulacao
    {
        Reagente Titulante { get; set; }
        Reagente Titulado { get; set; }
        List<ResultadoTitulacao> Replicatas { get; set; }
        double Resultado { get; set; }

        string GerarRelatorio();
    }
}

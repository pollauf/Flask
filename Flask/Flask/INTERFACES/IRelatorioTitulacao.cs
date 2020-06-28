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
        double ConcentracaoTitulado { get; set; }
        string GerarRelatorio();
    }
}

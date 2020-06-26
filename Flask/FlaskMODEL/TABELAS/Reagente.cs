using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL
{
    public class Reagente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; } = 0;
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoReagente Tipo { get; set; }
        public ForcaReagente Forca { get; set; }
        public ClasseReagente Valencia { get; set; }
        public double Concentracao { get; set; }
        public double KI1 { get; set; }
        public double KI2 { get; set; }
        public double KI3 { get; set; }
        public double KI4 { get; set; }
    }
}

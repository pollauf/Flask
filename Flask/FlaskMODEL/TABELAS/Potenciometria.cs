﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL.TABELAS
{
    public class Potenciometria
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int TituladoID { get; set; }
        public string DescricaoTitulante { get; set; }
        public string Valores { get; set; }
    }
}
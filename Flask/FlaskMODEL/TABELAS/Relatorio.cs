﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL.TABELAS
{
    public class Relatorio
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Analise { get; set; }
        public string Texto { get; set; }
        public DateTime Data { get; set; }
    }
}

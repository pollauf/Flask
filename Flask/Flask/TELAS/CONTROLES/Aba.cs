using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.CONTROLES
{
    public class Aba
    {
        public Aba(Form tela, string titulo)
        {
            Tela = tela;
            Titulo = titulo;
        }

        public Form Tela { get; set; }
        public string Titulo { get; set; }
    }
}

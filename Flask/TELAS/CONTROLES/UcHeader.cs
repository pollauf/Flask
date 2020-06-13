using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flask.TELAS.METODOS;

namespace Flask.TELAS.CONTROLES
{
    public partial class UcHeader : UserControl
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
                lblTitulo.Text = titulo;
            }
        }

        public UcHeader()
        {
            InitializeComponent();
        }
    }
}

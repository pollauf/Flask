using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.Reagentes
{
    public partial class FrmCadastroUnidadeMedida : Form
    {
        public FrmCadastroUnidadeMedida()
        {
            InitializeComponent();
        }

        private void FrmCadastroUnidadeMedida_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Left = (this.Width / 2) - this.panel1.Width/2;
            this.panel1.Top = (this.Height / 2 - this.panel1.Height/2)/2;
        }
    }
}

using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskUI.COMPONENTES
{
    public partial class FlaskTextBox : TextBox
    {
        public bool CampoObrigatorio { get; set; } = false;
        public DefinicaoCampo DefinicaoCampo { get; set; } = DefinicaoCampo.Texto;

        public FlaskTextBox()
        {
            InitializeComponent();
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            this.BackColor = Color.White;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (DefinicaoCampo == DefinicaoCampo.NumeroInteiro || DefinicaoCampo == DefinicaoCampo.NumeroReal)
            {
                if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') ||
                    (e.KeyChar == ',' && string.IsNullOrEmpty(Text)) ||
                    (e.KeyChar == ',' && DefinicaoCampo == DefinicaoCampo.NumeroInteiro) ||                    
                    (e.KeyChar == ',' && Text.IndexOf(',') > -1 && DefinicaoCampo == DefinicaoCampo.NumeroReal))
                    e.Handled = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (!Enabled)
                return;

            if (DefinicaoCampo == DefinicaoCampo.NumeroReal)
            {
               if (double.TryParse(Text, out double result))
                {
                    Text = result.ToString("0.00000");
                }
            }
        }
    }
}

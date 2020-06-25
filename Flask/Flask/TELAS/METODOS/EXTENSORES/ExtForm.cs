using Flask.TELAS.CONTROLES;
using FlaskUI.COMPONENTES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.METODOS.EXTENSORES
{
    public static class ExtForm
    {
        public static bool VerificarCamposObrigatorios(this Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is FlaskTextBox flaskTextBox)
                {
                    if (flaskTextBox.CampoObrigatorio && flaskTextBox.Visible && string.IsNullOrEmpty(flaskTextBox.Text))
                    {
                        flaskTextBox.BackColor = Color.Red;
                        flaskTextBox.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        public static void AdotarPredefinicoes(this Form form)
        {
            form.BackColor = Color.FromArgb(219, 222, 225);
        }
    }
}

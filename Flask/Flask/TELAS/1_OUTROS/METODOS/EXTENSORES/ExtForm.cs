using Flask.TELAS.CONTROLES;
using FlaskUI;
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
        public static bool VerificarCamposObrigatorios(this FlaskForm form)
        {
            List<Control> controls = GetAllControls(form);

            foreach (var control in controls)
            {
                if (control is FlaskTextBox flaskTextBox)
                {
                    if (flaskTextBox.CampoObrigatorio && flaskTextBox.Visible && string.IsNullOrEmpty(flaskTextBox.Text))
                    {
                        flaskTextBox.Erro = true;
                        flaskTextBox.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        public static void LimparCampos(this FlaskForm form)
        {
            List<Control> controls = GetAllControls(form);

            foreach (var control in controls)
            {
                if (control is FlaskTextBox flaskTextBox)
                {
                    ((FlaskTextBox)control).Text = string.Empty;
                    ((FlaskTextBox)control).Erro = false;
                }
            }

            form.SelectFirstControl();
        }
        private static void SelectFirstControl(this FlaskForm form)
        {
            var flaskTxts = new List<FlaskTextBox>();
            foreach (Control item in GetAllControls(form))
            {
                if (item is FlaskTextBox)
                {
                    flaskTxts.Add((FlaskTextBox)item);
                }
            }

            if (flaskTxts.Count > 0)
                flaskTxts.OrderBy(x => x.TabIndex).FirstOrDefault().Select();
        }

        private static List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox) list.Add(c);
                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
            }

            return list;
        }
        private static List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }
        public static void AdotarPredefinicoes(this Form form)
        {
            form.BackColor = Color.FromArgb(219, 222, 225);
        }
    }
}

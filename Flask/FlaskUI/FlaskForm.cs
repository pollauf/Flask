using FlaskUI.CLASSES;
using FlaskUI.COMPONENTES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskUI
{
    public partial class FlaskForm : Form
    {
        public Modo Modo { get; set; } = Modo.Novo;
        public FlaskForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(700, 500);
            this.Padding = new Padding(1, 1, 1, 40);
            this.BackColor = Color.FromArgb(219, 222, 225);
        }       

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(45, 54, 76), ButtonBorderStyle.Solid);
        }

        protected override void OnLoad(EventArgs e)
        {
            SelectFirstControl();
            base.OnLoad(e);
        }

        protected void SelectFirstControl()
        {
            var flaskTxts = new List<FlaskTextBox>();
            foreach (Control item in GetAllControls(this))
            {
                if (item is FlaskTextBox)
                {
                    flaskTxts.Add((FlaskTextBox)item);
                }
            }

            if (flaskTxts.Count > 0)
                flaskTxts.OrderBy(x => x.TabIndex).FirstOrDefault().Select();
        }

        protected List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox) list.Add(c);
                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
            }

            return list;
        }
        protected List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        /* public void SendWndProcCommand(ref Message m)
         {
             this.DefWndProc(ref m);
         }*/

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        public void Centralizar()
        {
            this.BringToFront();
            CenterToParent();
            this.Left = (((Control)this.Parent).Width / 2) - this.Width / 2;
            this.Top = (((Control)this.Parent).Height / 2 - this.Height / 2) / 2;
        }

        public void Maximize()
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

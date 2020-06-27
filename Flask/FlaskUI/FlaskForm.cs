using FlaskUI.CLASSES;
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
            base.OnLoad(e);
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

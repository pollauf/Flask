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
    public partial class FlaskGroupBox : Panel
    {
        public string Titulo { get; set; }
        private readonly Label label;
        public FlaskGroupBox()
        {
            InitializeComponent();
            Titulo = this.Name.ToString();
            label = new FlaskLabel();
            label.Text = this.Titulo;
            this.Font = label.Font;
            label.Font = new Font(label.Font.FontFamily.Name, label.Font.Size, FontStyle.Underline);            
            label.AutoSize = true;
            this.Controls.Add(label);
            this.Padding = new Padding(3, 3, 3, 3);
            label.Location = new Point(6, 6);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);           
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(45, 54, 76), ButtonBorderStyle.Solid);
            label.Text = this.Titulo;
        }

    }
}

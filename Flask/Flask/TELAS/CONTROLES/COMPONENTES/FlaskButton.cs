using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.CONTROLES.COMPONENTES
{
    public partial class FlaskButton : Button
    {
        public FlaskButton()
        {
            InitializeComponent();
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 59, 137);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 60, 195);
            this.BackColor = Color.FromArgb(45, 54, 76);
            this.ForeColor = Color.White;
            this.Size = new Size(115, 30);
            this.Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}

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
    public partial class FlaskSearchButton : FlaskButton
    {
        public FlaskSearchButton()
        {
            InitializeComponent();
            this.Size = this.MaximumSize = this.MinimumSize = new Size(23, 23);
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Color.Black;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.Lupa;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Text = string.Empty;            
        }
    }
}

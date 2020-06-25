using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace FlaskUI.COMPONENTES
{
    public partial class FlaskLabel : Label
    {
        public FlaskLabel()
        {
            InitializeComponent();            
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}

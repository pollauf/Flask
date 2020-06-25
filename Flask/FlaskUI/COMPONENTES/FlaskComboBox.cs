using FlaskUI.ENUMERABLES;
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
    public partial class FlaskComboBox : ComboBox
    {
        public FlaskComboBox()
        {
            InitializeComponent();
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        protected override void OnSelectedValueChanged(EventArgs e)
        {
            base.OnSelectedValueChanged(e);
        }
    }
}

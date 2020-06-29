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
        private bool aberta = false;
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
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!aberta)
                {
                    this.DroppedDown = true;
                    aberta = true;
                }
                else SendKeys.Send("{TAB}");

                e.Handled = true;
            }

        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            aberta = false;
        }
    }
}

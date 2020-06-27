using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.CONTROLES
{
    public partial class UcReplicata : UserControl
    {
        public ResultadoTitulacao Titulacao { get; set; }
        public event EventHandler ButtonRemoveClick;
        public UcReplicata(string valor)
        {
            InitializeComponent();
            lblValor.Text = valor;
        }

        protected void OnButtonRemoveClick(EventArgs e)
        {
            if (ButtonRemoveClick != null)
                ButtonRemoveClick(this, e);
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            ButtonRemoveClick.Invoke(this, new EventArgs());
        }

        private void LblValor_Click(object sender, EventArgs e)
        {
            checkBox.Checked = !checkBox.Checked;
        }
    }
}

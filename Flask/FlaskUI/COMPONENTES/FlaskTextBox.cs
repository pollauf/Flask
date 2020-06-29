using FlaskUI.CLASSES;
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
    public partial class FlaskTextBox : TextBox
    {
        private bool erro;

        public bool Erro
        {
            get { return erro; }
            set
            {
                erro = value;
                AtualizarCores();
            }
        }

        private bool ativo = true;

        public bool Ativo
        {
            get { return ativo; }
            set
            {
                ativo = value;
                this.ReadOnly = !Ativo;
                AtualizarCores();
            }
        }


        public bool CampoObrigatorio { get; set; } = false;
        public DefinicaoCampo DefinicaoCampo { get; set; } = DefinicaoCampo.Texto;

        private readonly Color corDesativo = Color.LightGray;
        private readonly Color corAtivo = Color.White;
        private readonly Color corErro = Color.Red;

        public FlaskTextBox()
        {
            InitializeComponent();
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.BackColor = corAtivo;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected void AtualizarCores()
        {
            if (this.ReadOnly)
                this.BackColor = corDesativo;
            else if (Erro)
                this.BackColor = corErro;
            else
                this.BackColor = corAtivo;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }               
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Erro = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (DefinicaoCampo == DefinicaoCampo.NumeroInteiro || DefinicaoCampo == DefinicaoCampo.NumeroReal)
            {
                if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') ||
                    (e.KeyChar == ',' && string.IsNullOrEmpty(Text)) ||
                    (e.KeyChar == ',' && DefinicaoCampo == DefinicaoCampo.NumeroInteiro) ||
                    (e.KeyChar == ',' && Text.IndexOf(',') > -1 && DefinicaoCampo == DefinicaoCampo.NumeroReal))
                    e.Handled = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (this.ReadOnly)
                return;

            if (DefinicaoCampo == DefinicaoCampo.NumeroReal)
            {
                if (double.TryParse(Text, out double result))
                {
                    Text = result.ToString("0.00000");
                }
            }
        }
    }
}

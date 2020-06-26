using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flask.TELAS.METODOS;

namespace Flask
{
    public partial class UcHeader : UserControl
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
                lblTitulo.Text = titulo;
            }
        }

        public UcHeader()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.Parent == Tela.FormPrincipal.ucAbas.AbaSelecionada.Tela)
                Tela.Fechar();
            else
                ((Form)this.Parent).Close();
        }
        private void UcHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ((Control)sender).Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Parent.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);

                this.DefWndProc(ref msg);

                //Tela.EnviarComando(ref msg);
            }
        }
    }
}

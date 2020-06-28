using Flask.TELAS.METODOS;
using FlaskMODEL;
using FlaskUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask
{
    public partial class FrmCarregando : FlaskForm
    {
        public bool PossuiUsuario { get; set; }
        public FrmCarregando()
        {
            InitializeComponent();
        }

        private async void Inicializar()
        {
            try
            {
                PossuiUsuario = await Task.Run(() => new FlaskDatabase().Usuario.Any());
                //await Task.Run(() => Thread.Sleep(2000));
                Close();
            }
            catch (Exception ex)
            {
                Tela.InformarErroFatal(ex);
                Application.Exit();
            }
        }

        private void FrmCarregando_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}

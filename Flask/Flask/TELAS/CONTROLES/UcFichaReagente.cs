using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlaskMODEL;
using FlaskUI.CLASSES;
using System.Security.Policy;
using FlaskMODEL.CONSULTAS;
using Flask.TELAS.METODOS;

namespace Flask.TELAS.CONTROLES
{
    public partial class UcFichaReagente : UserControl
    {
        public event EventHandler ReagenteChanged;
        public IConsulta Consulta { get; set; }

        private Reagente reagente;

        public Reagente Reagente
        {
            get { return reagente; }
            set
            {
                reagente = value;

                if (Reagente == null)
                {
                    pcbIcon.Image = Properties.Resources.iconPlus;
                    pcbIcon.Cursor = Cursors.Hand;
                    pnlInfo.Visible = btnRemover.Visible = false;
                }
                else
                {
                    pcbIcon.Image = Properties.Resources.iconReagente;
                    pcbIcon.Cursor = Cursors.Default;
                    pnlInfo.Visible = btnRemover.Visible = true;                    

                    var tipoReagente = Reagente.Tipo == TipoReagente.Acido ? "Ácido" : "Base";

                    if (Reagente.Forca != ForcaReagente.Desconhecida)
                    {
                        var forcaReagente = Reagente.Forca == ForcaReagente.Forte ? "Forte" : "Fraco";

                        if (Reagente.Forca == ForcaReagente.Fraca && Reagente.Tipo == TipoReagente.Base)
                            forcaReagente = "Fraca";

                        tipoReagente = $"{tipoReagente} {forcaReagente}";
                    }

                    var classeReagente = ((int)Reagente.Classe).ToString();

                    if (Reagente.Tipo == TipoReagente.Acido)
                        classeReagente += " H⁺";
                    else
                        classeReagente += " OH⁻";

                    lblNome.Text = Reagente.Nome;
                    lblTipo.Text = tipoReagente;
                    lblClasse.Text = classeReagente;
                    lblConcentracao.Text = $"[{Reagente.Concentracao.FormatarString()}]";                   
                }

                if (ReagenteChanged != null)
                    ReagenteChanged.Invoke(null, new EventArgs());
            }
        }


        public UcFichaReagente()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(45, 54, 76), ButtonBorderStyle.Solid);
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            Reagente = null;
        }

        private void PcbIcon_Click(object sender, EventArgs e)
        {
            try
            {
                if (Reagente == null)
                {
                    var id = Tela.ConsultaGeral(Consulta);
                    Reagente = new FlaskDatabase().Reagente.Where(x => x.ID == id).FirstOrDefault();                    
                }
            }
            catch (Exception ex)
            {
                Tela.InformarErroFatal(ex);
            }
        }       

        protected void OnReagenteChanged(EventArgs e)
        {
            if (ReagenteChanged != null)
                ReagenteChanged(this, e);
        }
    }
}

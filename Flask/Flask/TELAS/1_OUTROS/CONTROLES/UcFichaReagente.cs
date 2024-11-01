﻿using System;
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
        public bool ManterFixo { get; set; } = false;
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
                    pnlInfo.Visible = true;
                    btnRemover.Visible = !ManterFixo;

                    var tipoReagente = reagente.Tipo == TipoReagente.Acido ? "Ácido" : "Base";

                    if (reagente.Forca != ForcaReagente.Desconhecida)
                    {
                        var forcaReagente = reagente.Forca == ForcaReagente.Forte ? "Forte" : "Fraco";

                        if (reagente.Forca == ForcaReagente.Fraca && reagente.Tipo == TipoReagente.Base)
                            forcaReagente = "Fraca";

                        tipoReagente = $"{tipoReagente} {forcaReagente}";
                    }

                    if (reagente.Tipo == TipoReagente.Anfotero)
                        tipoReagente = "Anfótero";

                    var classeReagente = string.Empty;

                    if (reagente.Tipo == TipoReagente.Acido)
                        classeReagente = "Perde ";
                    else if (reagente.Tipo == TipoReagente.Base)
                        classeReagente = "Recebe ";
                    else if (reagente.Tipo == TipoReagente.Anfotero)
                        classeReagente = "Perde ou Recebe ";

                    classeReagente += ((int)reagente.Classe).ToString() + " H⁺";

                    lblNome.Text = Reagente.Nome;
                    lblTipo.Text = tipoReagente;
                    lblClasse.Text = classeReagente;
                    lblConcentracao.Text = reagente.Concentracao == 0 ? "[Desconhecida]" : $"[{Reagente.Concentracao.FormatarString()}]";
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

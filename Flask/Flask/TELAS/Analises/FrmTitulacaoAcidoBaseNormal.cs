using FlaskMODEL.CONSULTAS;
using FlaskUI;
using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flask.TELAS.METODOS.EXTENSORES;
using FlaskUI.CLASSES;
using Flask.TELAS.CONTROLES;

namespace Flask.TELAS.Analises
{
    public partial class FrmTitulacaoAcidoBaseNormal : FlaskForm
    {
        public IRelatorioTitulacao Relatorio { get; set; }
        public TipoAnalise TipoAnalise { get; set; }

        private bool manterConsultaFixa = false;
        private bool consultarTodosTipos = true;
        private TipoReagente consultaTitulante = TipoReagente.Base;
        private TipoReagente consultaTitulado = TipoReagente.Acido;
        public FrmTitulacaoAcidoBaseNormal()
        {
            InitializeComponent();
        }

        public FrmTitulacaoAcidoBaseNormal(TipoAnalise tipoAnalise)
        {
            InitializeComponent();

            manterConsultaFixa = true;
            consultarTodosTipos = false;

            if (tipoAnalise == TipoAnalise.Alcalimetria)
            {
                consultaTitulante = TipoReagente.Acido;
                consultaTitulado = TipoReagente.Base;
                this.Name = this.Text = "Alcalimetria";
            }
            else if (tipoAnalise == TipoAnalise.Acidimetria)
            {
                consultaTitulante = TipoReagente.Base;
                consultaTitulado = TipoReagente.Acido;
                this.Name = this.Text = "Acidimetria";
            }

            TipoAnalise = tipoAnalise;

            ucHeader1.Titulo = this.Text;
        }

        private void FrmTitulacaoAcidoBaseNormal_Load(object sender, EventArgs e)
        {
            AtualizarFiltros();
        }

        private void AtualizarFiltros()
        {
            UcTitulante.Consulta = new ConsultaReagenteFiltro(consultarTodosTipos, true, true, true, consultaTitulante);
            UcTitulado.Consulta = new ConsultaReagenteFiltro(consultarTodosTipos, false, true, false, consultaTitulado);
        }

        private void UcTitulante_ReagenteChanged(object sender, EventArgs e)
        {
            if (!manterConsultaFixa)
            {
                if (UcTitulante.Reagente != null || UcTitulado.Reagente != null)
                    consultarTodosTipos = false;
                else
                {
                    consultarTodosTipos = true;
                    AtualizarFiltros();
                    return;
                }

                if (UcTitulante.Reagente != null)
                {
                    consultaTitulante = UcTitulante.Reagente.Tipo;
                    consultaTitulado = consultaTitulante == TipoReagente.Acido ? TipoReagente.Base : TipoReagente.Acido;
                    AtualizarFiltros();
                    return;
                }

                if (UcTitulado.Reagente != null)
                {
                    consultaTitulado = UcTitulado.Reagente.Tipo;
                    consultaTitulante = consultaTitulado == TipoReagente.Acido ? TipoReagente.Base : TipoReagente.Acido;
                    AtualizarFiltros();
                    return;
                }
            }
        }

        private void FlaskButton1_Click(object sender, EventArgs e)
        {
            if (!this.VerificarCamposObrigatorios())
                return;

            if (UcTitulante.Reagente == null || UcTitulado.Reagente == null)
            {
                MessageBox.Show("Há reagente(s) sem preenchimento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double volumeTitulado = 0;
            double volumeTitulante = 0;

            if (!double.TryParse(txtVolumeTitulado.Text, out volumeTitulado))
                return;

            if (!double.TryParse(txtVolumeTitulante.Text, out volumeTitulante))
                return;

            ITitulacao titulacao = new Titulacao();

            titulacao.Titulado = UcTitulado.Reagente;
            titulacao.Titulante = UcTitulante.Reagente;

            double resultadoDouble = Math.Round(titulacao.Calcular(volumeTitulado, volumeTitulante), 5);
            string resultado = resultadoDouble.FormatarString();

            var ucReplicata = new UcReplicata(resultado);
            ucReplicata.Titulacao = new ResultadoTitulacao(volumeTitulado, volumeTitulante, resultadoDouble);
            ucReplicata.ButtonRemoveClick += RemoverReplicata;

            FLP.Controls.Add(ucReplicata);

            txtVolumeTitulante.Text = string.Empty;
            txtVolumeTitulante.Select();
        }

        private void RemoverReplicata(object sender, EventArgs e)
        {
            FLP.Controls.Remove((UcReplicata)sender);
        }

        private void FlaskButton2_Click(object sender, EventArgs e)
        {
            if (FLP.Controls.Count == 0)
            {
                MessageBox.Show("Não há replicatas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selecionados = new List<double>();
            var resultadosSelecionados = new List<ResultadoTitulacao>();
            foreach (var item in FLP.Controls)
            {
                if (item is UcReplicata)
                {
                    var ucItem = (UcReplicata)item;
                    if (ucItem.checkBox.Checked)
                    {
                        selecionados.Add(ucItem.Titulacao.Resultado);
                        resultadosSelecionados.Add(ucItem.Titulacao);
                    }
                }
            }

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma replicata", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selecionados.Count < 3)
            {
                if (MessageBox.Show("Existem menos de 3 replicatas selecionadas, deseja continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.No)
                    return;
            }

            double media = Math.Round(selecionados.Average(), 5); ;
            lblResultado.Text = $"Resultado: {media.FormatarString()} mol/L";

            if (TipoAnalise == TipoAnalise.Acidimetria)
            {
                Relatorio = new RelatorioAcidimetria(UcTitulante.Reagente, UcTitulado.Reagente, resultadosSelecionados, media);
            }
            else if (TipoAnalise == TipoAnalise.Alcalimetria)
            {
                Relatorio = new RelatorioAlcalimetria(UcTitulante.Reagente, UcTitulado.Reagente, resultadosSelecionados, media);
            }

        }

        private void TxtVolumeTitulante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FlaskButton1_Click(null, new EventArgs());
            }
        }

        private void FlaskButton4_Click(object sender, EventArgs e)
        {
            if (Relatorio != null)
            {
                MessageBox.Show(Relatorio.GerarRelatorio());
            }
        }
    }
}

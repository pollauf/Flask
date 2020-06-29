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
using Flask.TELAS.METODOS;
using FlaskMODEL.TABELAS;
using System.Threading;

namespace Flask.TELAS.Analises
{
    public partial class FrmTitulacaoAcidoBaseNormal : FlaskForm
    {
        private IRelatorioTitulacao relatorio;

        public IRelatorioTitulacao Relatorio
        {
            get { return relatorio; }
            set
            {
                relatorio = value;

                if (Relatorio == null)
                {
                    lblResultado.Text = "Resultado:";
                    flaskButton3.Visible = flaskButton4.Visible = false;
                }
                else
                {
                    flaskButton3.Visible = true;

                    if (TipoAnalise != TipoAnalise.Retrotitulacao)
                        flaskButton4.Visible = true;
                }
            }
        }

        public TipoAnalise TipoAnalise { get; set; }

        private bool manterConsultaFixa = false;
        public FrmTitulacaoAcidoBaseNormal()
        {
            InitializeComponent();
        }

        public FrmTitulacaoAcidoBaseNormal(TipoAnalise tipoAnalise)
        {
            InitializeComponent();

            manterConsultaFixa = true;

            if (tipoAnalise == TipoAnalise.Alcalimetria)
            {
                this.Name = this.Text = "Alcalimetria";
            }
            else if (tipoAnalise == TipoAnalise.Acidimetria)
            {
                this.Name = this.Text = "Acidimetria";
            }

            TipoAnalise = tipoAnalise;

            ucHeader1.Titulo = this.Text;
        }

        public FrmTitulacaoAcidoBaseNormal(TipoAnalise tipoAnalise, Reagente titulado)
        {
            InitializeComponent();

            if (tipoAnalise == TipoAnalise.Retrotitulacao)
            {
                this.Name = "TitulacaoExcesso";
                this.Text = ucHeader1.Titulo = "Titulação do Excesso";
                gpbReplicatas.Titulo = "REPLICATAS (mL Titulante)";
                UcTitulado.ManterFixo = true;

                flaskButton3.Text = "Ok";

                lblVolumeTitulado.Visible = txtVolumeTitulado.Visible =
                    lblUnidadeTitulado.Visible = flaskButton4.Visible = false;
            }

            UcTitulado.Reagente = titulado;
            TipoAnalise = tipoAnalise;
        }

        private void FrmTitulacaoAcidoBaseNormal_Load(object sender, EventArgs e)
        {
            AtualizarFiltros();
        }

        private void AtualizarFiltros()
        {
            var tipoTitulante = TipoReagente.Anfotero;
            var tipoTitulado = TipoReagente.Anfotero;

            if (TipoAnalise == TipoAnalise.Acidimetria)
            {
                tipoTitulante = TipoReagente.Base;
                tipoTitulado = TipoReagente.Acido;
            }
            else if (TipoAnalise == TipoAnalise.Alcalimetria)
            {
                tipoTitulante = TipoReagente.Acido;
                tipoTitulado = TipoReagente.Base;
            }
            else
            {
                if (UcTitulado.Reagente != null)
                    tipoTitulante = UcTitulado.Reagente.Tipo.RetornarReagenteOposto();

                if (UcTitulante.Reagente != null)
                    tipoTitulado = UcTitulante.Reagente.Tipo.RetornarReagenteOposto();
            }

            UcTitulante.Consulta = new ConsultaReagenteTitulacao(tipoTitulante, true);
            UcTitulado.Consulta = new ConsultaReagenteTitulacao(tipoTitulado, false);
        }

        private void UcTitulante_ReagenteChanged(object sender, EventArgs e)
        {
            this.Relatorio = null;
            FLP.Controls.Clear();
            if (!manterConsultaFixa)
            {
                AtualizarFiltros();
            }
            txtVolumeTitulado.Select();
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

            if (TipoAnalise != TipoAnalise.Retrotitulacao)
            {
                if (!double.TryParse(txtVolumeTitulado.Text, out volumeTitulado))
                    return;
            }

            if (!double.TryParse(txtVolumeTitulante.Text, out volumeTitulante))
                return;

            ITitulacao titulacao = new Titulacao();

            ((ITitulanteTitulado)titulacao).Titulado = UcTitulado.Reagente;
            ((ITitulanteTitulado)titulacao).Titulante = UcTitulante.Reagente;

            double resultadoTitulacao = 0;

            if (TipoAnalise != TipoAnalise.Retrotitulacao)
                resultadoTitulacao = titulacao.CalcularConcentracao(volumeTitulado, volumeTitulante);
            else
                resultadoTitulacao = 0;

            double resultadoDouble = Math.Round(resultadoTitulacao, 5);
            string resultado = resultadoDouble.FormatarString();

            var ucReplicata = new UcReplicata(resultado, TipoAnalise);

            if (TipoAnalise == TipoAnalise.Retrotitulacao)
                ucReplicata = new UcReplicata(volumeTitulante.FormatarString(), TipoAnalise);

            if (TipoAnalise != TipoAnalise.Retrotitulacao)
                ucReplicata.Titulacao = new ResultadoTitulacao(volumeTitulado, volumeTitulante, resultadoDouble);
            else
                ucReplicata.Titulacao = new ResultadoTitulacao(resultadoDouble, volumeTitulante, UcTitulado.Reagente.Concentracao);

            ucReplicata.ButtonRemoveClick += RemoverReplicata;

            FLP.Controls.Add(ucReplicata);

            txtVolumeTitulante.Text = string.Empty;
            txtVolumeTitulante.Select();
        }

        private void RemoverReplicata(object sender, EventArgs e)
        {
            FLP.Controls.Remove((UcReplicata)sender);
            Relatorio = null;
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
                        if (TipoAnalise != TipoAnalise.Retrotitulacao)
                        {
                            selecionados.Add(ucItem.Titulacao.ConcentracaoTitulado);
                        }
                        else
                        {
                            selecionados.Add(ucItem.Titulacao.VolumeTitulante);
                        }
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

            if (TipoAnalise != TipoAnalise.Retrotitulacao)
            {
                Relatorio = new RelatorioTitulacao(TipoAnalise, UcTitulante.Reagente, UcTitulado.Reagente, resultadosSelecionados, media);
                lblResultado.Text = $"Resultado: {media.FormatarString()} mol/L";
            }
            else
            {
                Relatorio = new RelatorioTitulacao(TipoAnalise, UcTitulante.Reagente, UcTitulado.Reagente, resultadosSelecionados, UcTitulado.Reagente.Concentracao);
                lblResultado.Text = $"Resultado: {media.FormatarString()} mL";
            }
        }

        private async void TxtVolumeTitulante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FlaskButton1_Click(null, new EventArgs());
            }

            await Task.Run(() => Thread.Sleep(100));
            txtVolumeTitulante.Select();
        }

        private void FlaskButton4_Click(object sender, EventArgs e)
        {
            if (Relatorio != null)
            {
                if (Relatorio == null)
                    return;

                var relatorio = new Relatorio
                {
                    Analise = "Titulação",
                    Texto = Relatorio.GerarRelatorio(),
                };

                relatorio.Salvar(Modo.Novo, true);

                flaskButton4.Visible = false;
            }
        }

        private void FlaskButton3_Click(object sender, EventArgs e)
        {
            if (Relatorio != null)
            {
                if (TipoAnalise == TipoAnalise.Retrotitulacao)
                {
                    Close();
                    return;
                }                    

                if (!Tela.PerguntarDesejaAlterar("Deseja alterar a concentração do analito em seu registro?"))
                    return;

                try
                {
                    Reagente analito = UcTitulado.Reagente;
                    analito.Concentracao = Relatorio.ConcentracaoTitulado;

                    analito.Salvar(Modo.Alteracao);
                    this.LimparCampos();

                    UcTitulado.Reagente = analito;

                    flaskButton3.Visible = false;
                }
                catch (Exception ex)
                {
                    Tela.InformarErro(ex);
                }
            }
        }
    }
}
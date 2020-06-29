using Flask.TELAS.METODOS;
using Flask.TELAS.METODOS.EXTENSORES;
using FlaskMODEL;
using FlaskMODEL.CONSULTAS;
using FlaskMODEL.TABELAS;
using FlaskUI;
using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.Analises
{
    public partial class FrmRetrotitulacao : FlaskForm
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
                    lblResultadoConcentracao.Text = lblResultadoExcesso.Text = "Resultado: ";
                    flaskButton3.Visible = flaskButton4.Visible = false;
                }
            }
        }

        public FrmRetrotitulacao()
        {
            InitializeComponent();
        }

        private void FlaskButton1_Click(object sender, EventArgs e)
        {
            if (ucExcesso.Reagente == null || ucAnalito.Reagente == null)
            {
                MessageBox.Show("Há reagente(s) sem preenchimento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double volumeAnalito = 0;
            double volumeExcesso = 0;

            if (!double.TryParse(txtVolumeAnalito.Text, out volumeAnalito))
                return;

            if (!double.TryParse(txtVolumeExcesso.Text, out volumeExcesso))
                return;

            lblResultadoExcesso.Text = "Resultado:";
            Relatorio = null;

            var frm = new FrmTitulacaoAcidoBaseNormal(TipoAnalise.Retrotitulacao, ucExcesso.Reagente);
            frm.ShowDialog();

            if (frm.Relatorio == null)
                return;

            IRelatorioTitulacao relatorioTitulacao = frm.Relatorio;

            var retrotitulacao = new Retrotitulacao((ITitulanteTitulado)relatorioTitulacao, ucExcesso.Reagente, ucAnalito.Reagente);

            ITitulacao titulacaoExcesso = new Titulacao();
            ((ITitulanteTitulado)titulacaoExcesso).Titulante = ((ITitulanteTitulado)relatorioTitulacao).Titulante;
            ((ITitulanteTitulado)titulacaoExcesso).Titulado = ((ITitulanteTitulado)relatorioTitulacao).Titulado;

            var volumes = new List<double>();
            double mediaVolume = 0;

            foreach (var item in ((IReplicatas)relatorioTitulacao).Replicatas)
            {
                double volumeExcessoRestante = titulacaoExcesso.CalcularVolumeTitulado(item.VolumeTitulante);
                double volumeExcessoReagido = volumeExcesso - volumeExcessoRestante;
                item.VolumeTitulado = volumeExcessoReagido;
                volumes.Add(volumeExcessoReagido);
            }

            mediaVolume = Math.Round(volumes.Average(), 5);

            var resultado = Math.Round(retrotitulacao.CalcularConcentracao(volumeAnalito, mediaVolume), 5);
            Relatorio = new RelatorioRetrotitulacao(relatorioTitulacao, ucExcesso.Reagente, ucAnalito.Reagente, resultado);

            lblResultadoExcesso.Text = $"Resultado: {mediaVolume.FormatarString()} mL";
            lblResultadoConcentracao.Text = "Resultado:";
            flaskButton4.Visible = flaskButton3.Visible = false;
        }

        private void ucHeader1_Load(object sender, EventArgs e)
        {

        }

        private void FrmRetrotitulacao_Load(object sender, EventArgs e)
        {
            AtualizarFiltros();
        }

        private void UcExcesso_ReagenteChanged(object sender, EventArgs e)
        {
            this.Relatorio = null;
            AtualizarFiltros();
        }
        private void AtualizarFiltros()
        {
            var tipoExcesso = TipoReagente.Anfotero;
            var tipoAnalito = TipoReagente.Anfotero;

            if (ucAnalito.Reagente != null)
                tipoExcesso = ucAnalito.Reagente.Tipo.RetornarReagenteOposto();

            if (ucExcesso.Reagente != null)
                tipoAnalito = ucExcesso.Reagente.Tipo.RetornarReagenteOposto();

            ucExcesso.Consulta = new ConsultaReagenteTitulacao(tipoExcesso, true);
            ucAnalito.Consulta = new ConsultaReagenteTitulacao(tipoAnalito, false);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (Relatorio != null)
            {
                lblResultadoConcentracao.Text = $"Resultado: {Relatorio.ConcentracaoTitulado.FormatarString()} mol/L";
                flaskButton4.Visible = flaskButton3.Visible = true;
            }
            else
                MessageBox.Show("É necessário realizar a titulação do excesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FlaskButton4_Click(object sender, EventArgs e)
        {
            if (Relatorio == null)
                return;

            var relatorio = new Relatorio
            {
                Analise = "Retrotitulação",
                Texto = Relatorio.GerarRelatorio(),
            };

            relatorio.Salvar(Modo.Novo, true);

            flaskButton4.Visible = false;
        }

        private void FlaskButton3_Click(object sender, EventArgs e)
        {
            if (!Tela.PerguntarDesejaAlterar("Deseja alterar a concentração do analito em seu registro?"))
                return;

            try
            {
                Reagente analito = ucAnalito.Reagente;
                analito.Concentracao = Relatorio.ConcentracaoTitulado;

                analito.Salvar(Modo.Alteracao);
                this.LimparCampos();

                ucAnalito.Reagente = analito;

                flaskButton3.Visible = false;
            }
            catch (Exception ex)
            {
                Tela.InformarErro(ex);
            }
        }
    }
}

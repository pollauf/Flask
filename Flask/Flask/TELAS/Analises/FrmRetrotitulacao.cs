using FlaskMODEL;
using FlaskMODEL.CONSULTAS;
using FlaskUI;
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
        public IRelatorioTitulacao Relatorio { get; set; }
        private bool consultarTodosTipos = true;
        private TipoReagente consultaTitulante = TipoReagente.Base;
        private TipoReagente consultaTitulado = TipoReagente.Acido;
        public FrmRetrotitulacao()
        {
            InitializeComponent();
        }

        private void FlaskButton1_Click(object sender, EventArgs e)
        {
            if (ucExcesso.Reagente == null)
                return;

            double volumeAnalito = 0;
            double volumeExcesso = 0;

            if (!double.TryParse(txtVolumeAnalito.Text, out volumeAnalito))
                return;

            if (!double.TryParse(txtVolumeExcesso.Text, out volumeExcesso))
                return;

            var frm = new FrmTitulacaoAcidoBaseNormal(TipoAnalise.Retrotitulacao, ucExcesso.Reagente);
            frm.ShowDialog();

            if (frm.Relatorio == null)
                return;

            IRelatorioTitulacao relatorioTitulacao = frm.Relatorio;

            var retrotitulacao = new Retrotitulacao((ITitulanteTitulado)relatorioTitulacao, ucExcesso.Reagente, ucAnalito.Reagente);

            var volumes = new List<double>();
            double mediaVolume = 0;
            foreach (var item in ((IReplicatas)relatorioTitulacao).Replicatas)
                volumes.Add(item.VolumeTitulado);

            mediaVolume = Math.Round(volumes.Average(), 5);

            var resultado = retrotitulacao.CalcularConcentracao(volumeExcesso, volumeAnalito, mediaVolume);
            Relatorio = new RelatorioRetrotitulacao(relatorioTitulacao, ucExcesso.Reagente, ucAnalito.Reagente, resultado);

            MessageBox.Show(Relatorio.GerarRelatorio());
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

            if (ucExcesso.Reagente != null || ucAnalito.Reagente != null)
                consultarTodosTipos = false;
            else
            {
                consultarTodosTipos = true;
                AtualizarFiltros();
                return;
            }

            if (ucExcesso.Reagente != null)
            {
                consultaTitulante = ucExcesso.Reagente.Tipo;
                consultaTitulado = consultaTitulante == TipoReagente.Acido ? TipoReagente.Base : TipoReagente.Acido;
                AtualizarFiltros();
                return;
            }

            if (ucAnalito.Reagente != null)
            {
                consultaTitulado = ucAnalito.Reagente.Tipo;
                consultaTitulante = consultaTitulado == TipoReagente.Acido ? TipoReagente.Base : TipoReagente.Acido;
                AtualizarFiltros();
                return;
            }
        }
        private void AtualizarFiltros()
        {
            ucExcesso.Consulta = new ConsultaReagenteFiltro(consultarTodosTipos, true, true, true, consultaTitulante);
            ucAnalito.Consulta = new ConsultaReagenteFiltro(consultarTodosTipos, false, true, false, consultaTitulado);
        }
    }
}

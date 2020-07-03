using Flask.TELAS.Analises;
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
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.Reagentes
{
    public partial class FrmCadastroReagente : FlaskForm
    {
        private Grafico graficoExpansor;

        Reagente model;
        public FrmCadastroReagente()
        {
            InitializeComponent();
        }

        private void flaskTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlaskSearchButton1_Click(object sender, EventArgs e)
        {
            int id = Tela.ConsultaGeral(new ConsultaReagente());
            if (id != -1)
            {
                txtID.Text = id.ToString();
                TxtID_Leave(null, new EventArgs());
            }
        }

        private void FrmCadastroReagente_Load(object sender, EventArgs e)
        {
            model = new Reagente();
            txtTipo.Carregar(Metodos.EnumToList<TipoReagente>());
            txtForca.Carregar(Metodos.EnumToList<ForcaReagente>());
            txtComboConcentracao.Carregar(Metodos.EnumToList<Concentracao>());
            AtualizarControlesConstanteIonizacao();

            /*graficoPotenciometria.ChartAreas[0].AxisX.Title = "Volume (mL)";
            graficoPotenciometria.ChartAreas[0].AxisY.Title = "pH";*/

            graficoExpansor = new Grafico();
            graficoExpansor.InicializarGrafico(graficoPotenciometria);

            //txtID.Select();
        }

        private void FlaskComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarControlesConstanteIonizacao();
        }

        private void RbClasseMono_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarControlesConstanteIonizacao();
        }

        private void AtualizarControlesConstanteIonizacao()
        {
            var forcaReagente = (ForcaReagente)txtForca.SelectedIndex;

            if (forcaReagente == ForcaReagente.Desconhecida || forcaReagente == ForcaReagente.Forte)
            {
                flaskGroupBox2.Visible = false;
                return;
            }

            flaskGroupBox2.Visible = true;

            if (rbClasseMono.Checked || rbClasseDesconhecida.Checked)
            {
                pnlK1.Visible = true;
                pnlK2.Visible = pnlK3.Visible = pnlK4.Visible = false;
            }
            else if (rbClasseDi.Checked)
            {
                pnlK1.Visible = pnlK2.Visible = true;
                pnlK3.Visible = pnlK4.Visible = false;
            }
            else if (rbClasseTri.Checked)
            {
                pnlK1.Visible = pnlK2.Visible = pnlK3.Visible = true;
                pnlK4.Visible = false;
            }
            else if (rbClasseTetra.Checked)
            {
                pnlK1.Visible = pnlK2.Visible = pnlK3.Visible = pnlK4.Visible = true;
            }

            var controlesFlowLayoutPanel = new List<Control>();

            foreach (Control item in panel1.Controls)
                if (item.Visible)
                    controlesFlowLayoutPanel.Add(item);

            controlesFlowLayoutPanel = controlesFlowLayoutPanel.OrderBy(x => x.Name).ToList();

            for (int i = 0; i < controlesFlowLayoutPanel.Count; i++)
                controlesFlowLayoutPanel[i].Location = new Point(pnlK1.Width * i, 0);

        }

        private void ComboConcentracao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Concentracao)txtComboConcentracao.SelectedIndex) == Concentracao.Conhecida)
            {
                lblMols.Visible = txtConcentracao.Visible = true;
                txtConcentracao.CampoObrigatorio = true;
            }
            else
            {
                lblMols.Visible = txtConcentracao.Visible = false;
                txtConcentracao.Text = string.Empty;
                txtConcentracao.CampoObrigatorio = false;
            }
        }

        private void FlaskButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.VerificarCamposObrigatorios())
                    return;

                if (!ValidarInformacoes())
                    return;

                model.Nome = txtNome.Text;
                model.Descricao = txtDescricao.Text;
                model.Tipo = (TipoReagente)txtTipo.SelectedIndex;

                var classeSelecionada = ClasseReagente.Desconhecida;
                if (rbClasseDesconhecida.Checked)
                    classeSelecionada = ClasseReagente.Desconhecida;
                else if (rbClasseMono.Checked)
                    classeSelecionada = ClasseReagente.Mono;
                else if (rbClasseDi.Checked)
                    classeSelecionada = ClasseReagente.Di;
                else if (rbClasseTri.Checked)
                    classeSelecionada = ClasseReagente.Tri;
                else if (rbClasseTetra.Checked)
                    classeSelecionada = ClasseReagente.Tetra;

                model.Classe = classeSelecionada;
                model.Forca = (ForcaReagente)txtForca.SelectedIndex;
                model.Concentracao = string.IsNullOrEmpty(txtConcentracao.Text) ? 0 : double.Parse(txtConcentracao.Text);
                model.MassaMolar = string.IsNullOrEmpty(txtMassaMolar.Text) ? 0 : double.Parse(txtMassaMolar.Text);
                model.Formula = txtFormula.Text;

                model.KI1 = string.IsNullOrEmpty(txtK1.Text) ? 0 : double.Parse(txtK1.Text);
                model.KI2 = string.IsNullOrEmpty(txtK2.Text) ? 0 : double.Parse(txtK2.Text);
                model.KI3 = string.IsNullOrEmpty(txtK3.Text) ? 0 : double.Parse(txtK3.Text);
                model.KI4 = string.IsNullOrEmpty(txtK4.Text) ? 0 : double.Parse(txtK4.Text);

                model.Salvar(Modo);

                txtID.Select();

                Modo = Modo.Alteracao;
                txtID.Text = model.ID.ToString("000000");

            }
            catch (Exception ex)
            {
                Tela.InformarErroFatal(ex);
            }
        }

        private bool ValidarInformacoes()
        {
            var forcaReagente = (ForcaReagente)txtForca.SelectedIndex;

            if (forcaReagente == ForcaReagente.Desconhecida || forcaReagente == ForcaReagente.Forte)
            {
                txtK1.Text = txtK2.Text = txtK3.Text = txtK4.Text = string.Empty;
            }
            else if (rbClasseDesconhecida.Checked || rbClasseMono.Checked)
            {
                txtK2.Text = txtK3.Text = txtK4.Text = string.Empty;
            }
            else if (rbClasseDi.Checked)
            {
                txtK3.Text = txtK4.Text = string.Empty;
            }
            else if (rbClasseTri.Checked)
            {
                txtK4.Text = string.Empty;
            }

            if (((Concentracao)txtComboConcentracao.SelectedIndex) == Concentracao.Desconhecida)
            {
                txtConcentracao.Text = string.Empty;
            }

            return true;
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
                return;

            CarregarRegistro(id);
        }

        private void CarregarRegistro(int id)
        {
            try
            {
                if (model.ID == id)
                    return;

                OcultarGrafico();

                using (FlaskDatabase db = new FlaskDatabase())
                {
                    var query = db.Reagente.Where(x => x.ID == id).FirstOrDefault();

                    if (query == null)
                    {
                        Limpar(null, new EventArgs());
                        return;
                    }

                    model = query;

                    txtID.Text = model.ID.ToString("000000");
                    txtID.Ativo = false;
                    txtNome.Text = model.Nome;
                    txtDescricao.Text = model.Descricao;
                    txtFormula.Text = model.Formula;

                    if (model.Concentracao > 0)
                    {
                        txtComboConcentracao.SelectedIndex = (int)Concentracao.Conhecida;
                        txtConcentracao.Text = model.Concentracao.FormatarString();
                    }

                    if (model.MassaMolar > 0)
                        txtMassaMolar.Text = model.MassaMolar.FormatarString();

                    txtTipo.SelectedIndex = (int)model.Tipo;
                    txtForca.SelectedIndex = (int)model.Forca;

                    if (model.Classe == ClasseReagente.Desconhecida)
                        rbClasseDesconhecida.Checked = true;
                    else if (model.Classe == ClasseReagente.Mono)
                        rbClasseMono.Checked = true;
                    else if (model.Classe == ClasseReagente.Di)
                        rbClasseDi.Checked = true;
                    else if (model.Classe == ClasseReagente.Tri)
                        rbClasseTri.Checked = true;
                    else if (model.Classe == ClasseReagente.Tetra)
                        rbClasseTetra.Checked = true;

                    txtK1.Text = model.KI1 == 0 ? string.Empty : model.KI1.FormatarString();
                    txtK2.Text = model.KI2 == 0 ? string.Empty : model.KI2.FormatarString();
                    txtK3.Text = model.KI3 == 0 ? string.Empty : model.KI3.FormatarString();
                    txtK4.Text = model.KI4 == 0 ? string.Empty : model.KI4.FormatarString();

                    var potenciometria = db.Potenciometria.Where(x => x.TituladoID == model.ID).FirstOrDefault();
                    if (potenciometria != null)
                        CarregarGrafico(potenciometria);
                    else
                        OcultarGrafico();

                    Modo = Modo.Alteracao;
                    txtNome.Select();
                }
            }
            catch (Exception ex)
            {
                Tela.InformarErro(ex);
                Limpar(null, new EventArgs());
            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            Modo = Modo.Novo;
            model = new Reagente();
            this.LimparCampos();

            txtID.Ativo = true;
            txtComboConcentracao.SelectedIndex = (int)Concentracao.Desconhecida;
            txtTipo.SelectedIndex = (int)TipoReagente.Acido;
            txtForca.SelectedIndex = (int)ForcaReagente.Desconhecida;
            rbClasseDesconhecida.Checked = true;
            tabControl1.SelectTab(0);

            txtID.Select();
            OcultarGrafico();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modo != Modo.Alteracao)
                    return;

                if (!Tela.PerguntarDesejaExcluir())
                    return;

                model.Excluir();

                Limpar(null, new EventArgs());
            }
            catch (Exception ex)
            {
                Tela.InformarErroFatal(ex);
            }
        }

        private void BtnExcluirGraficoPotenciometria_Click(object sender, EventArgs e)
        {
            var potenciometria = new FlaskDatabase().Potenciometria.Where(x => x.TituladoID == model.ID).FirstOrDefault();

            if (potenciometria != null)
            {
                potenciometria.Excluir();
                Tela.InformarExcluidoSucesso();
                OcultarGrafico();
            }
        }

        private void OcultarGrafico()
        {
            rtbTitultanteGrafico.Text = string.Empty;
            dgvPotenciometria.Rows.Clear();
            graficoPotenciometria.Series[0].Points.Clear();
            pnlOcultarGrafico.Show();
        }

        private void MostrarGrafico()
        {
            pnlOcultarGrafico.Hide();
        }

        private void CarregarGrafico(Potenciometria potenciometria)
        {
            var lista = new List<Potenciometrica>();
            lista = lista.GerarLista(potenciometria.Valores);

            foreach (var item in lista)
            {
                dgvPotenciometria.Rows.Add(item.Volume.FormatarString(), item.pH.FormatarString());
                graficoPotenciometria.Series[0].Points.AddXY(item.Volume, item.pH);
            }

            rtbTitultanteGrafico.Text = "TITULANTE:\n" + potenciometria.DescricaoTitulante;

            graficoExpansor.AdicionarTagGrafico(potenciometria);

            MostrarGrafico();
        }

        private void BtnTitulacaoPotenciometrica_Click(object sender, EventArgs e)
        {
            if (model == null)
            {
                MessageBox.Show("Crie ou abra um cadastro antes de continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (model.ID == 0)
            {
                MessageBox.Show("Salve este cadastro antes de continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tela.Fechar();
            Tela.Abrir(new FrmPotenciometrica(model), "POTENCIOMETRIA");            
        }
    }
}

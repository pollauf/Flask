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
using System.Runtime.Remoting.Channels;

namespace Flask.TELAS.CONTROLES
{
    public partial class UcAbas : UserControl
    {
        public List<Aba> Abas
        {
            get
            {
                List<Aba> abas = new List<Aba>();

                foreach (Control item in flowLayoutPanel1.Controls)
                    if (item is Button)
                        abas.Add((Aba)item.Tag);

                return abas;
            }
        }

        private Aba abaSelecionada;

        public Aba AbaSelecionada { get { return abaSelecionada; } }

        public UcAbas()
        {
            InitializeComponent();
        }

        #region Outras_Funcionalidades
        public void LimparSelecoes()
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Transparent;
                    item.ForeColor = Color.LightGray;
                    ((Button)item.Controls[0]).ForeColor = Color.LightGray;
                }
            }
        }

        public void Aba_Click(object sender, EventArgs e)
        {
            SelecionarAba((Button)sender);
        }

        public void AtualizarScroll()
        {
            if (flowLayoutPanel1.Controls.Count == 0)
                return;

            if (flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1].Right > flowLayoutPanel1.Right)
                this.Height = 51;
            else
                this.Height = 30;
        }

        private void FlowLayoutPanel1_ControlChanged(object sender, ControlEventArgs e) => AtualizarScroll();
        private void UcAbas_SizeChanged(object sender, EventArgs e) => AtualizarScroll();
        #endregion

        #region Selecao
        public void SelecionarAba(Button button)
        {
            if (abaSelecionada != null)
                abaSelecionada.Tela.Hide();

            LimparSelecoes();

            button.BackColor = Color.FromArgb(45, 54, 76);
            button.ForeColor = Color.White;
            ((Button)button.Controls[0]).ForeColor = Color.White;
            abaSelecionada = (Aba)button.Tag;

            abaSelecionada.Tela.Show();
            abaSelecionada.Tela.BringToFront();
            abaSelecionada.Tela.Centralizar();
            if (abaSelecionada.Tela.WindowState == FormWindowState.Maximized)
            {
                abaSelecionada.Tela.WindowState = FormWindowState.Normal;
                abaSelecionada.Tela.WindowState = FormWindowState.Maximized;
            }

            Tela.FormPrincipal.StrJanelaAberta = ((Aba)button.Tag).Titulo;
        }

        public bool SelecionarAbaPorNome(string formName)
        {
            Button button = ProcurarAba(formName);

            if (button == null)
                return false;

            SelecionarAba(button);

            return true;
        }

        public void SelecionarUltimaAba()
        {
            SelecionarAba((Button)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
        }
        #endregion

        #region Adicionar_Remover_Procurar
        public void AdicionarAba(Aba aba)
        {
            if (abaSelecionada != null)
                abaSelecionada.Tela.Hide();

            LimparSelecoes();

            Button btnAba = new Button
            {
                Text = aba.Titulo.ToUpper(),
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.FromArgb(45, 54, 76),
                ForeColor = Color.White,
                Font = new Font("Calibri", 9, FontStyle.Bold),
                MaximumSize = new Size(0, 30),
                MinimumSize = new Size(120, 30),
                Margin = new Padding(0, 0, 0, 0),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowOnly,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
            };

            btnAba.FlatAppearance.BorderSize = 0;
            btnAba.FlatAppearance.MouseDownBackColor =
                btnAba.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 54, 76);

            Button btnFechar = new Button
            {
                Text = "X",
                Font = new Font("Calibri", 9, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                MinimumSize = new Size(30, 30),
                MaximumSize = new Size(30, 30),
                Dock = DockStyle.Right,
                Margin = new Padding(0, 0, 3, 0),
                Tag = aba.Tela.Name,
                Cursor = Cursors.Hand,
            };

            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor =
                 btnFechar.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnFechar.MouseHover += BtnFechar_Hover;
            btnFechar.MouseLeave += BtnFechar_Leave;

            btnAba.Controls.Add(btnFechar);

            btnAba.Tag = aba;

            flowLayoutPanel1.Controls.Add(btnAba);
            btnAba.Size = new Size(btnAba.Width + 20, 30);

            btnAba.Click += Aba_Click;
            btnFechar.Click += BtnFecharAba_Click;

            abaSelecionada = aba;
        }

        private void BtnFechar_Hover(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.ForeColor = Color.Gray;
        }

        private void BtnFechar_Leave(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.ForeColor = ((Button)btn.Parent).ForeColor;
        }

        public void RemoverAba(string formName)
        {
            Button aba = ProcurarAba(formName);

            if (abaSelecionada != null)
                if (formName == abaSelecionada.Tela.Name)
                    abaSelecionada = null;

            ((Aba)aba.Tag).Tela.Close();
            ((Aba)aba.Tag).Tela.Dispose();

            flowLayoutPanel1.Controls.Remove(aba);
            Tela.FormPrincipal.StrJanelaAberta = string.Empty;

            if (flowLayoutPanel1.Controls.Count > 0)
                SelecionarUltimaAba();

            Tela.AtualizarPlanoFundo();
        }

        public void BtnFecharAba_Click(object sender, EventArgs e)
        {
            RemoverAba(((Control)sender).Tag.ToString());
        }

        public Button ProcurarAba(string formName)
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Button)
                {
                    if (((Aba)item.Tag).Tela.Name == formName)
                    {
                        return (Button)item;
                    }
                }
            }

            return null;
        }
        #endregion
    }
}

using Flask.TELAS.METODOS;
using Flask.TELAS.METODOS.EXTENSORES;
using FlaskMODEL;
using FlaskMODEL.TABELAS;
using FlaskUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask
{
    public partial class FrmLogin : FlaskForm
    {
        public bool Validado { get; set; }
        public bool PossuiUsuario { get; set; }
        public FrmLogin()
        {
            InitializeComponent();

            var frm = new FrmCarregando();
            frm.ShowDialog();

            PossuiUsuario = frm.PossuiUsuario;

            Validado = false;

            if (!PossuiUsuario)
                SetarTemaCriarUsuario();
        }

        public void SetarTemaFazerLogin()
        {
            txtUsuario.Select();
            ckbLembrar.Visible = true;
            PossuiUsuario = true;
            txtSenha.PasswordChar = '•';
            btnEntrar.Text = "Entrar";
            ucHeader1.Titulo = "Fazer Login";
        }

        public void SetarTemaCriarUsuario()
        {
            txtUsuario.Select();
            ckbLembrar.Visible = false;
            txtSenha.PasswordChar = '\0';
            btnEntrar.Text = "Registrar";
            ucHeader1.Titulo = "Criar Usuário";
        }

        private void GravarCredenciais()
        {
            Properties.Settings.Default.LembrarLogin = ckbLembrar.Checked;
            if (ckbLembrar.Checked)
            {
                Properties.Settings.Default.Login = txtUsuario.Text;
                Properties.Settings.Default.Senha = txtSenha.Text;
            }
            else
            {
                Properties.Settings.Default.Login =
                    Properties.Settings.Default.Senha = string.Empty;
            }
            Properties.Settings.Default.Save();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (!this.VerificarCamposObrigatorios())
                return;

            try
            {
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    if (PossuiUsuario)
                    {
                        if (db.Usuario.Any(x => x.Login == txtUsuario.Text && x.Senha == txtSenha.Text))
                        {
                            GravarCredenciais();

                            Validado = true;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuário e/ou senha inválidos.", "Credenciais Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSenha.Text = string.Empty;
                            txtSenha.Select();
                            return;
                        }
                    }
                    else
                    {
                        if (txtSenha.Text.Length < 8)
                        {
                            MessageBox.Show("A senha deve ter no mínimo 8 caracteres.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var usuario = new Usuario { Login = txtUsuario.Text, Senha = txtSenha.Text };

                        Usuario oldestModel = db.Usuario.OrderByDescending(x => x.ID).FirstOrDefault();
                        usuario.ID = oldestModel == null ? 1 : oldestModel.ID + 1;

                        db.Entry(usuario).State = EntityState.Added;
                        db.Usuario.Add(usuario);
                        db.SaveChanges();

                        MessageBox.Show("Usuário cadastrado com sucesso.", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimparCampos();
                        SetarTemaFazerLogin();
                        GravarCredenciais();
                    }
                }
            }
            catch (Exception ex)
            {
                Tela.InformarErro(ex);
            }
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSenha.Select();
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnEntrar_Click(null, new EventArgs());
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (PossuiUsuario)
            {
                ckbLembrar.Checked = Properties.Settings.Default.LembrarLogin;
                if (ckbLembrar.Checked)
                {
                    txtUsuario.Text = Properties.Settings.Default.Login;
                    txtSenha.Text = Properties.Settings.Default.Senha;
                }
            }
        }
    }
}

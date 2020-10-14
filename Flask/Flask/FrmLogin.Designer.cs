namespace Flask
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.flaskLabel1 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.txtUsuario = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.txtSenha = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.flaskLabel2 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.btnEntrar = new FlaskUI.COMPONENTES.FlaskButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckbLembrar = new System.Windows.Forms.CheckBox();
            this.ucHeader1 = new Flask.UcHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flaskLabel1
            // 
            this.flaskLabel1.AutoSize = true;
            this.flaskLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel1.Location = new System.Drawing.Point(123, 46);
            this.flaskLabel1.Name = "flaskLabel1";
            this.flaskLabel1.Size = new System.Drawing.Size(57, 17);
            this.flaskLabel1.TabIndex = 2;
            this.flaskLabel1.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Ativo = true;
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.CampoObrigatorio = true;
            this.txtUsuario.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.Texto;
            this.txtUsuario.Erro = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(126, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            // 
            // txtSenha
            // 
            this.txtSenha.Ativo = true;
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.CampoObrigatorio = true;
            this.txtSenha.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.Texto;
            this.txtSenha.Erro = false;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.Location = new System.Drawing.Point(126, 112);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(200, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            // 
            // flaskLabel2
            // 
            this.flaskLabel2.AutoSize = true;
            this.flaskLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel2.Location = new System.Drawing.Point(123, 92);
            this.flaskLabel2.Name = "flaskLabel2";
            this.flaskLabel2.Size = new System.Drawing.Size(49, 17);
            this.flaskLabel2.TabIndex = 4;
            this.flaskLabel2.Text = "Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(211, 141);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(115, 30);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ckbLembrar
            // 
            this.ckbLembrar.AutoSize = true;
            this.ckbLembrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ckbLembrar.Location = new System.Drawing.Point(14, 147);
            this.ckbLembrar.Name = "ckbLembrar";
            this.ckbLembrar.Size = new System.Drawing.Size(114, 21);
            this.ckbLembrar.TabIndex = 5;
            this.ckbLembrar.Text = "Lembrar login";
            this.ckbLembrar.UseVisualStyleBackColor = true;
            // 
            // ucHeader1
            // 
            this.ucHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Location = new System.Drawing.Point(1, 1);
            this.ucHeader1.MaximumSize = new System.Drawing.Size(0, 25);
            this.ucHeader1.MinimumSize = new System.Drawing.Size(330, 25);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.NaoEhFilho = true;
            this.ucHeader1.Size = new System.Drawing.Size(338, 25);
            this.ucHeader1.TabIndex = 1;
            this.ucHeader1.TabStop = false;
            this.ucHeader1.Titulo = "Login";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 190);
            this.Controls.Add(this.ckbLembrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.flaskLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.flaskLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucHeader1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcHeader ucHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel1;
        private FlaskUI.COMPONENTES.FlaskTextBox txtUsuario;
        private FlaskUI.COMPONENTES.FlaskTextBox txtSenha;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel2;
        private FlaskUI.COMPONENTES.FlaskButton btnEntrar;
        private System.Windows.Forms.CheckBox ckbLembrar;
    }
}
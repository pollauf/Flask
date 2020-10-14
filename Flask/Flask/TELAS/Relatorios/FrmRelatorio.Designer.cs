namespace Flask
{
    partial class FrmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.ucHeader1 = new Flask.UcHeader();
            this.flaskGroupBox1 = new FlaskUI.COMPONENTES.FlaskGroupBox();
            this.flaskLabel2 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.txtAnalise = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.flaskLabel1 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.flaskSearchButton1 = new FlaskUI.COMPONENTES.FlaskSearchButton();
            this.txtID = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.ucRTF1 = new Flask.TELAS.CONTROLES.UcRTF();
            this.btnExcluir = new FlaskUI.COMPONENTES.FlaskButton();
            this.btnLimpar = new FlaskUI.COMPONENTES.FlaskButton();
            this.btnSalvar = new FlaskUI.COMPONENTES.FlaskButton();
            this.flaskGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucHeader1
            // 
            this.ucHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Location = new System.Drawing.Point(1, 1);
            this.ucHeader1.MaximumSize = new System.Drawing.Size(0, 25);
            this.ucHeader1.MinimumSize = new System.Drawing.Size(330, 25);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.NaoEhFilho = false;
            this.ucHeader1.Size = new System.Drawing.Size(615, 25);
            this.ucHeader1.TabIndex = 0;
            this.ucHeader1.TabStop = false;
            this.ucHeader1.Titulo = "Registro";
            // 
            // flaskGroupBox1
            // 
            this.flaskGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flaskGroupBox1.Controls.Add(this.flaskLabel2);
            this.flaskGroupBox1.Controls.Add(this.txtAnalise);
            this.flaskGroupBox1.Controls.Add(this.flaskLabel1);
            this.flaskGroupBox1.Controls.Add(this.flaskSearchButton1);
            this.flaskGroupBox1.Controls.Add(this.txtID);
            this.flaskGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskGroupBox1.Location = new System.Drawing.Point(4, 38);
            this.flaskGroupBox1.Name = "flaskGroupBox1";
            this.flaskGroupBox1.Padding = new System.Windows.Forms.Padding(3);
            this.flaskGroupBox1.Size = new System.Drawing.Size(609, 67);
            this.flaskGroupBox1.TabIndex = 1;
            this.flaskGroupBox1.Titulo = "Capa";
            // 
            // flaskLabel2
            // 
            this.flaskLabel2.AutoSize = true;
            this.flaskLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel2.Location = new System.Drawing.Point(208, 34);
            this.flaskLabel2.Name = "flaskLabel2";
            this.flaskLabel2.Size = new System.Drawing.Size(54, 17);
            this.flaskLabel2.TabIndex = 7;
            this.flaskLabel2.Text = "Análise";
            // 
            // txtAnalise
            // 
            this.txtAnalise.Ativo = true;
            this.txtAnalise.BackColor = System.Drawing.Color.White;
            this.txtAnalise.CampoObrigatorio = true;
            this.txtAnalise.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.Texto;
            this.txtAnalise.Erro = false;
            this.txtAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAnalise.Location = new System.Drawing.Point(266, 31);
            this.txtAnalise.Name = "txtAnalise";
            this.txtAnalise.Size = new System.Drawing.Size(100, 23);
            this.txtAnalise.TabIndex = 6;
            // 
            // flaskLabel1
            // 
            this.flaskLabel1.AutoSize = true;
            this.flaskLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel1.Location = new System.Drawing.Point(6, 34);
            this.flaskLabel1.Name = "flaskLabel1";
            this.flaskLabel1.Size = new System.Drawing.Size(52, 17);
            this.flaskLabel1.TabIndex = 5;
            this.flaskLabel1.Text = "Código";
            // 
            // flaskSearchButton1
            // 
            this.flaskSearchButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskSearchButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flaskSearchButton1.BackgroundImage")));
            this.flaskSearchButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flaskSearchButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flaskSearchButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.flaskSearchButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.flaskSearchButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.flaskSearchButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flaskSearchButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskSearchButton1.ForeColor = System.Drawing.Color.White;
            this.flaskSearchButton1.Location = new System.Drawing.Point(170, 31);
            this.flaskSearchButton1.MaximumSize = new System.Drawing.Size(23, 23);
            this.flaskSearchButton1.MinimumSize = new System.Drawing.Size(23, 23);
            this.flaskSearchButton1.Name = "flaskSearchButton1";
            this.flaskSearchButton1.Size = new System.Drawing.Size(23, 23);
            this.flaskSearchButton1.TabIndex = 1;
            this.flaskSearchButton1.TabStop = false;
            this.flaskSearchButton1.UseVisualStyleBackColor = false;
            this.flaskSearchButton1.Click += new System.EventHandler(this.FlaskSearchButton1_Click);
            // 
            // txtID
            // 
            this.txtID.Ativo = true;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CampoObrigatorio = false;
            this.txtID.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.NumeroInteiro;
            this.txtID.Erro = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.Location = new System.Drawing.Point(64, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.Leave += new System.EventHandler(this.TxtID_Leave);
            // 
            // ucRTF1
            // 
            this.ucRTF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRTF1.Location = new System.Drawing.Point(4, 111);
            this.ucRTF1.Name = "ucRTF1";
            this.ucRTF1.Size = new System.Drawing.Size(609, 319);
            this.ucRTF1.TabIndex = 2;
            this.ucRTF1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(4, 436);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 30);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(377, 436);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 30);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(498, 436);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 30);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 474);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ucRTF1);
            this.Controls.Add(this.flaskGroupBox1);
            this.Controls.Add(this.ucHeader1);
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.flaskGroupBox1.ResumeLayout(false);
            this.flaskGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UcHeader ucHeader1;
        private FlaskUI.COMPONENTES.FlaskGroupBox flaskGroupBox1;
        private TELAS.CONTROLES.UcRTF ucRTF1;
        private FlaskUI.COMPONENTES.FlaskButton btnExcluir;
        private FlaskUI.COMPONENTES.FlaskButton btnLimpar;
        private FlaskUI.COMPONENTES.FlaskButton btnSalvar;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel1;
        private FlaskUI.COMPONENTES.FlaskSearchButton flaskSearchButton1;
        private FlaskUI.COMPONENTES.FlaskTextBox txtID;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel2;
        private FlaskUI.COMPONENTES.FlaskTextBox txtAnalise;
    }
}
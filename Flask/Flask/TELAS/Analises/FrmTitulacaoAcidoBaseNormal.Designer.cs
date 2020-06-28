namespace Flask.TELAS.Analises
{
    partial class FrmTitulacaoAcidoBaseNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTitulacaoAcidoBaseNormal));
            this.flaskGroupBox1 = new FlaskUI.COMPONENTES.FlaskGroupBox();
            this.UcTitulante = new Flask.TELAS.CONTROLES.UcFichaReagente();
            this.flaskGroupBox2 = new FlaskUI.COMPONENTES.FlaskGroupBox();
            this.UcTitulado = new Flask.TELAS.CONTROLES.UcFichaReagente();
            this.flaskGroupBox3 = new FlaskUI.COMPONENTES.FlaskGroupBox();
            this.lblUnidadeTitulado = new FlaskUI.COMPONENTES.FlaskLabel();
            this.flaskLabel3 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.flaskButton1 = new FlaskUI.COMPONENTES.FlaskButton();
            this.lblVolumeTitulado = new FlaskUI.COMPONENTES.FlaskLabel();
            this.txtVolumeTitulado = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.flaskLabel1 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.txtVolumeTitulante = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.gpbReplicatas = new FlaskUI.COMPONENTES.FlaskGroupBox();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.flaskButton2 = new FlaskUI.COMPONENTES.FlaskButton();
            this.flaskButton3 = new FlaskUI.COMPONENTES.FlaskButton();
            this.flaskButton4 = new FlaskUI.COMPONENTES.FlaskButton();
            this.lblResultado = new FlaskUI.COMPONENTES.FlaskLabel();
            this.ucHeader1 = new Flask.UcHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flaskGroupBox1.SuspendLayout();
            this.flaskGroupBox2.SuspendLayout();
            this.flaskGroupBox3.SuspendLayout();
            this.gpbReplicatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flaskGroupBox1
            // 
            this.flaskGroupBox1.Controls.Add(this.UcTitulante);
            this.flaskGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flaskGroupBox1.Location = new System.Drawing.Point(147, 160);
            this.flaskGroupBox1.Name = "flaskGroupBox1";
            this.flaskGroupBox1.Padding = new System.Windows.Forms.Padding(3);
            this.flaskGroupBox1.Size = new System.Drawing.Size(293, 130);
            this.flaskGroupBox1.TabIndex = 3;
            this.flaskGroupBox1.Titulo = "Titulante";
            // 
            // UcTitulante
            // 
            this.UcTitulante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.UcTitulante.Consulta = null;
            this.UcTitulante.Location = new System.Drawing.Point(6, 28);
            this.UcTitulante.ManterFixo = false;
            this.UcTitulante.MaximumSize = new System.Drawing.Size(280, 95);
            this.UcTitulante.MinimumSize = new System.Drawing.Size(280, 95);
            this.UcTitulante.Name = "UcTitulante";
            this.UcTitulante.Reagente = null;
            this.UcTitulante.Size = new System.Drawing.Size(280, 95);
            this.UcTitulante.TabIndex = 2;
            this.UcTitulante.ReagenteChanged += new System.EventHandler(this.UcTitulante_ReagenteChanged);
            // 
            // flaskGroupBox2
            // 
            this.flaskGroupBox2.Controls.Add(this.UcTitulado);
            this.flaskGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flaskGroupBox2.Location = new System.Drawing.Point(147, 296);
            this.flaskGroupBox2.Name = "flaskGroupBox2";
            this.flaskGroupBox2.Padding = new System.Windows.Forms.Padding(3);
            this.flaskGroupBox2.Size = new System.Drawing.Size(293, 130);
            this.flaskGroupBox2.TabIndex = 4;
            this.flaskGroupBox2.Titulo = "Titulado";
            // 
            // UcTitulado
            // 
            this.UcTitulado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.UcTitulado.Consulta = null;
            this.UcTitulado.Location = new System.Drawing.Point(6, 28);
            this.UcTitulado.ManterFixo = false;
            this.UcTitulado.MaximumSize = new System.Drawing.Size(280, 95);
            this.UcTitulado.MinimumSize = new System.Drawing.Size(280, 95);
            this.UcTitulado.Name = "UcTitulado";
            this.UcTitulado.Reagente = null;
            this.UcTitulado.Size = new System.Drawing.Size(280, 95);
            this.UcTitulado.TabIndex = 2;
            this.UcTitulado.ReagenteChanged += new System.EventHandler(this.UcTitulante_ReagenteChanged);
            // 
            // flaskGroupBox3
            // 
            this.flaskGroupBox3.Controls.Add(this.lblUnidadeTitulado);
            this.flaskGroupBox3.Controls.Add(this.flaskLabel3);
            this.flaskGroupBox3.Controls.Add(this.flaskButton1);
            this.flaskGroupBox3.Controls.Add(this.lblVolumeTitulado);
            this.flaskGroupBox3.Controls.Add(this.txtVolumeTitulado);
            this.flaskGroupBox3.Controls.Add(this.flaskLabel1);
            this.flaskGroupBox3.Controls.Add(this.txtVolumeTitulante);
            this.flaskGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskGroupBox3.Location = new System.Drawing.Point(147, 47);
            this.flaskGroupBox3.Name = "flaskGroupBox3";
            this.flaskGroupBox3.Padding = new System.Windows.Forms.Padding(3);
            this.flaskGroupBox3.Size = new System.Drawing.Size(496, 107);
            this.flaskGroupBox3.TabIndex = 5;
            this.flaskGroupBox3.Titulo = "Dados";
            // 
            // lblUnidadeTitulado
            // 
            this.lblUnidadeTitulado.AutoSize = true;
            this.lblUnidadeTitulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUnidadeTitulado.Location = new System.Drawing.Point(313, 35);
            this.lblUnidadeTitulado.Name = "lblUnidadeTitulado";
            this.lblUnidadeTitulado.Size = new System.Drawing.Size(27, 17);
            this.lblUnidadeTitulado.TabIndex = 7;
            this.lblUnidadeTitulado.Text = "mL";
            // 
            // flaskLabel3
            // 
            this.flaskLabel3.AutoSize = true;
            this.flaskLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel3.Location = new System.Drawing.Point(313, 64);
            this.flaskLabel3.Name = "flaskLabel3";
            this.flaskLabel3.Size = new System.Drawing.Size(27, 17);
            this.flaskLabel3.TabIndex = 6;
            this.flaskLabel3.Text = "mL";
            // 
            // flaskButton1
            // 
            this.flaskButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flaskButton1.FlatAppearance.BorderSize = 0;
            this.flaskButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.flaskButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.flaskButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flaskButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskButton1.ForeColor = System.Drawing.Color.White;
            this.flaskButton1.Location = new System.Drawing.Point(375, 54);
            this.flaskButton1.Name = "flaskButton1";
            this.flaskButton1.Size = new System.Drawing.Size(115, 30);
            this.flaskButton1.TabIndex = 2;
            this.flaskButton1.Text = "Calcular";
            this.flaskButton1.UseVisualStyleBackColor = false;
            this.flaskButton1.Click += new System.EventHandler(this.FlaskButton1_Click);
            // 
            // lblVolumeTitulado
            // 
            this.lblVolumeTitulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVolumeTitulado.Location = new System.Drawing.Point(13, 35);
            this.lblVolumeTitulado.Name = "lblVolumeTitulado";
            this.lblVolumeTitulado.Size = new System.Drawing.Size(188, 17);
            this.lblVolumeTitulado.TabIndex = 4;
            this.lblVolumeTitulado.Text = "Volume de Titulado Utilizado";
            this.lblVolumeTitulado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVolumeTitulado
            // 
            this.txtVolumeTitulado.Ativo = true;
            this.txtVolumeTitulado.BackColor = System.Drawing.Color.White;
            this.txtVolumeTitulado.CampoObrigatorio = true;
            this.txtVolumeTitulado.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.NumeroReal;
            this.txtVolumeTitulado.Erro = false;
            this.txtVolumeTitulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVolumeTitulado.Location = new System.Drawing.Point(207, 32);
            this.txtVolumeTitulado.Name = "txtVolumeTitulado";
            this.txtVolumeTitulado.Size = new System.Drawing.Size(100, 23);
            this.txtVolumeTitulado.TabIndex = 0;
            this.txtVolumeTitulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flaskLabel1
            // 
            this.flaskLabel1.AutoSize = true;
            this.flaskLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel1.Location = new System.Drawing.Point(25, 64);
            this.flaskLabel1.Name = "flaskLabel1";
            this.flaskLabel1.Size = new System.Drawing.Size(176, 17);
            this.flaskLabel1.TabIndex = 2;
            this.flaskLabel1.Text = "Volume de Titulante Gasto";
            // 
            // txtVolumeTitulante
            // 
            this.txtVolumeTitulante.Ativo = true;
            this.txtVolumeTitulante.BackColor = System.Drawing.Color.White;
            this.txtVolumeTitulante.CampoObrigatorio = true;
            this.txtVolumeTitulante.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.NumeroReal;
            this.txtVolumeTitulante.Erro = false;
            this.txtVolumeTitulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVolumeTitulante.Location = new System.Drawing.Point(207, 61);
            this.txtVolumeTitulante.Name = "txtVolumeTitulante";
            this.txtVolumeTitulante.Size = new System.Drawing.Size(100, 23);
            this.txtVolumeTitulante.TabIndex = 1;
            this.txtVolumeTitulante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVolumeTitulante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtVolumeTitulante_KeyDown);
            // 
            // gpbReplicatas
            // 
            this.gpbReplicatas.Controls.Add(this.FLP);
            this.gpbReplicatas.Controls.Add(this.flaskButton2);
            this.gpbReplicatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gpbReplicatas.Location = new System.Drawing.Point(446, 160);
            this.gpbReplicatas.Name = "gpbReplicatas";
            this.gpbReplicatas.Padding = new System.Windows.Forms.Padding(3);
            this.gpbReplicatas.Size = new System.Drawing.Size(197, 238);
            this.gpbReplicatas.TabIndex = 6;
            this.gpbReplicatas.Titulo = "Replicatas  [TITULADO]";
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FLP.Location = new System.Drawing.Point(6, 30);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(185, 166);
            this.FLP.TabIndex = 7;
            // 
            // flaskButton2
            // 
            this.flaskButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flaskButton2.FlatAppearance.BorderSize = 0;
            this.flaskButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.flaskButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.flaskButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flaskButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskButton2.ForeColor = System.Drawing.Color.White;
            this.flaskButton2.Location = new System.Drawing.Point(6, 202);
            this.flaskButton2.Name = "flaskButton2";
            this.flaskButton2.Size = new System.Drawing.Size(185, 30);
            this.flaskButton2.TabIndex = 6;
            this.flaskButton2.Text = "Obter Média";
            this.flaskButton2.UseVisualStyleBackColor = false;
            this.flaskButton2.Click += new System.EventHandler(this.FlaskButton2_Click);
            // 
            // flaskButton3
            // 
            this.flaskButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flaskButton3.FlatAppearance.BorderSize = 0;
            this.flaskButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.flaskButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.flaskButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flaskButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskButton3.ForeColor = System.Drawing.Color.White;
            this.flaskButton3.Location = new System.Drawing.Point(475, 432);
            this.flaskButton3.Name = "flaskButton3";
            this.flaskButton3.Size = new System.Drawing.Size(168, 30);
            this.flaskButton3.TabIndex = 7;
            this.flaskButton3.Text = "Salvar Concentração";
            this.flaskButton3.UseVisualStyleBackColor = false;
            this.flaskButton3.Visible = false;
            this.flaskButton3.Click += new System.EventHandler(this.FlaskButton3_Click);
            // 
            // flaskButton4
            // 
            this.flaskButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flaskButton4.FlatAppearance.BorderSize = 0;
            this.flaskButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.flaskButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.flaskButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flaskButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskButton4.ForeColor = System.Drawing.Color.White;
            this.flaskButton4.Location = new System.Drawing.Point(15, 432);
            this.flaskButton4.Name = "flaskButton4";
            this.flaskButton4.Size = new System.Drawing.Size(168, 30);
            this.flaskButton4.TabIndex = 8;
            this.flaskButton4.Text = "Gerar Relatório";
            this.flaskButton4.UseVisualStyleBackColor = false;
            this.flaskButton4.Visible = false;
            this.flaskButton4.Click += new System.EventHandler(this.FlaskButton4_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultado.Location = new System.Drawing.Point(446, 401);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(197, 25);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucHeader1
            // 
            this.ucHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Location = new System.Drawing.Point(1, 1);
            this.ucHeader1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ucHeader1.MinimumSize = new System.Drawing.Size(330, 40);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.Size = new System.Drawing.Size(653, 40);
            this.ucHeader1.TabIndex = 0;
            this.ucHeader1.Titulo = "Titulação";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 47);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(126, 379);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(126, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTitulacaoAcidoBaseNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 468);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.flaskButton4);
            this.Controls.Add(this.flaskButton3);
            this.Controls.Add(this.gpbReplicatas);
            this.Controls.Add(this.flaskGroupBox3);
            this.Controls.Add(this.flaskGroupBox2);
            this.Controls.Add(this.flaskGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucHeader1);
            this.Name = "FrmTitulacaoAcidoBaseNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulação";
            this.Load += new System.EventHandler(this.FrmTitulacaoAcidoBaseNormal_Load);
            this.flaskGroupBox1.ResumeLayout(false);
            this.flaskGroupBox1.PerformLayout();
            this.flaskGroupBox2.ResumeLayout(false);
            this.flaskGroupBox2.PerformLayout();
            this.flaskGroupBox3.ResumeLayout(false);
            this.flaskGroupBox3.PerformLayout();
            this.gpbReplicatas.ResumeLayout(false);
            this.gpbReplicatas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcHeader ucHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CONTROLES.UcFichaReagente UcTitulante;
        private FlaskUI.COMPONENTES.FlaskGroupBox flaskGroupBox1;
        private FlaskUI.COMPONENTES.FlaskGroupBox flaskGroupBox2;
        private CONTROLES.UcFichaReagente UcTitulado;
        private FlaskUI.COMPONENTES.FlaskGroupBox flaskGroupBox3;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton1;
        private FlaskUI.COMPONENTES.FlaskLabel lblVolumeTitulado;
        private FlaskUI.COMPONENTES.FlaskTextBox txtVolumeTitulado;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel1;
        private FlaskUI.COMPONENTES.FlaskTextBox txtVolumeTitulante;
        private FlaskUI.COMPONENTES.FlaskGroupBox gpbReplicatas;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton2;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton3;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton4;
        private FlaskUI.COMPONENTES.FlaskLabel lblUnidadeTitulado;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel3;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private FlaskUI.COMPONENTES.FlaskLabel lblResultado;
    }
}
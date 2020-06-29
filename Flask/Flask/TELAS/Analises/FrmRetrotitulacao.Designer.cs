namespace Flask.TELAS.Analises
{
    partial class FrmRetrotitulacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetrotitulacao));
            this.flaskButton4 = new FlaskUI.COMPONENTES.FlaskButton();
            this.flaskGroupBox3 = new FlaskUI.COMPONENTES.FlaskGroupBox();
            this.flaskLabel1 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.lblUnidadeTitulado = new FlaskUI.COMPONENTES.FlaskLabel();
            this.flaskLabel3 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.lblVolumeTitulado = new FlaskUI.COMPONENTES.FlaskLabel();
            this.txtVolumeAnalito = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.txtVolumeExcesso = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.flaskButton1 = new FlaskUI.COMPONENTES.FlaskButton();
            this.flaskGroupBox2 = new FlaskUI.COMPONENTES.FlaskGroupBox();
            this.ucAnalito = new Flask.TELAS.CONTROLES.UcFichaReagente();
            this.flaskGroupBox1 = new FlaskUI.COMPONENTES.FlaskGroupBox();
            this.ucExcesso = new Flask.TELAS.CONTROLES.UcFichaReagente();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResultadoExcesso = new FlaskUI.COMPONENTES.FlaskLabel();
            this.flaskLabel2 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.btnCalcular = new FlaskUI.COMPONENTES.FlaskButton();
            this.lblResultadoConcentracao = new FlaskUI.COMPONENTES.FlaskLabel();
            this.flaskLabel4 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.flaskButton3 = new FlaskUI.COMPONENTES.FlaskButton();
            this.ucHeader1 = new Flask.UcHeader();
            this.flaskGroupBox3.SuspendLayout();
            this.flaskGroupBox2.SuspendLayout();
            this.flaskGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.flaskButton4.Location = new System.Drawing.Point(14, 432);
            this.flaskButton4.Name = "flaskButton4";
            this.flaskButton4.Size = new System.Drawing.Size(168, 30);
            this.flaskButton4.TabIndex = 2;
            this.flaskButton4.Text = "Gerar Relatório";
            this.flaskButton4.UseVisualStyleBackColor = false;
            this.flaskButton4.Visible = false;
            this.flaskButton4.Click += new System.EventHandler(this.FlaskButton4_Click);
            // 
            // flaskGroupBox3
            // 
            this.flaskGroupBox3.Controls.Add(this.flaskLabel1);
            this.flaskGroupBox3.Controls.Add(this.lblUnidadeTitulado);
            this.flaskGroupBox3.Controls.Add(this.flaskLabel3);
            this.flaskGroupBox3.Controls.Add(this.lblVolumeTitulado);
            this.flaskGroupBox3.Controls.Add(this.txtVolumeAnalito);
            this.flaskGroupBox3.Controls.Add(this.txtVolumeExcesso);
            this.flaskGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskGroupBox3.Location = new System.Drawing.Point(146, 47);
            this.flaskGroupBox3.Name = "flaskGroupBox3";
            this.flaskGroupBox3.Padding = new System.Windows.Forms.Padding(3);
            this.flaskGroupBox3.Size = new System.Drawing.Size(458, 107);
            this.flaskGroupBox3.TabIndex = 12;
            this.flaskGroupBox3.Titulo = "Dados";
            // 
            // flaskLabel1
            // 
            this.flaskLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel1.Location = new System.Drawing.Point(13, 39);
            this.flaskLabel1.Name = "flaskLabel1";
            this.flaskLabel1.Size = new System.Drawing.Size(167, 17);
            this.flaskLabel1.TabIndex = 8;
            this.flaskLabel1.Text = "Reagente em Excesso";
            this.flaskLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUnidadeTitulado
            // 
            this.lblUnidadeTitulado.AutoSize = true;
            this.lblUnidadeTitulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUnidadeTitulado.Location = new System.Drawing.Point(292, 68);
            this.lblUnidadeTitulado.Name = "lblUnidadeTitulado";
            this.lblUnidadeTitulado.Size = new System.Drawing.Size(27, 17);
            this.lblUnidadeTitulado.TabIndex = 7;
            this.lblUnidadeTitulado.Text = "mL";
            // 
            // flaskLabel3
            // 
            this.flaskLabel3.AutoSize = true;
            this.flaskLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel3.Location = new System.Drawing.Point(292, 39);
            this.flaskLabel3.Name = "flaskLabel3";
            this.flaskLabel3.Size = new System.Drawing.Size(124, 17);
            this.flaskLabel3.TabIndex = 6;
            this.flaskLabel3.Text = "mL (Volume Total)";
            // 
            // lblVolumeTitulado
            // 
            this.lblVolumeTitulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVolumeTitulado.Location = new System.Drawing.Point(16, 68);
            this.lblVolumeTitulado.Name = "lblVolumeTitulado";
            this.lblVolumeTitulado.Size = new System.Drawing.Size(164, 17);
            this.lblVolumeTitulado.TabIndex = 4;
            this.lblVolumeTitulado.Text = "Volume de Analito";
            this.lblVolumeTitulado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVolumeAnalito
            // 
            this.txtVolumeAnalito.Ativo = true;
            this.txtVolumeAnalito.BackColor = System.Drawing.Color.White;
            this.txtVolumeAnalito.CampoObrigatorio = true;
            this.txtVolumeAnalito.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.NumeroReal;
            this.txtVolumeAnalito.Erro = false;
            this.txtVolumeAnalito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVolumeAnalito.Location = new System.Drawing.Point(186, 65);
            this.txtVolumeAnalito.Name = "txtVolumeAnalito";
            this.txtVolumeAnalito.Size = new System.Drawing.Size(100, 23);
            this.txtVolumeAnalito.TabIndex = 1;
            this.txtVolumeAnalito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVolumeExcesso
            // 
            this.txtVolumeExcesso.Ativo = true;
            this.txtVolumeExcesso.BackColor = System.Drawing.Color.White;
            this.txtVolumeExcesso.CampoObrigatorio = true;
            this.txtVolumeExcesso.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.NumeroReal;
            this.txtVolumeExcesso.Erro = false;
            this.txtVolumeExcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVolumeExcesso.Location = new System.Drawing.Point(186, 36);
            this.txtVolumeExcesso.Name = "txtVolumeExcesso";
            this.txtVolumeExcesso.Size = new System.Drawing.Size(100, 23);
            this.txtVolumeExcesso.TabIndex = 0;
            this.txtVolumeExcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.flaskButton1.Location = new System.Drawing.Point(445, 160);
            this.flaskButton1.Name = "flaskButton1";
            this.flaskButton1.Size = new System.Drawing.Size(159, 30);
            this.flaskButton1.TabIndex = 0;
            this.flaskButton1.Text = "Titulação do Excesso";
            this.flaskButton1.UseVisualStyleBackColor = false;
            this.flaskButton1.Click += new System.EventHandler(this.FlaskButton1_Click);
            // 
            // flaskGroupBox2
            // 
            this.flaskGroupBox2.Controls.Add(this.ucAnalito);
            this.flaskGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flaskGroupBox2.Location = new System.Drawing.Point(146, 296);
            this.flaskGroupBox2.Name = "flaskGroupBox2";
            this.flaskGroupBox2.Padding = new System.Windows.Forms.Padding(3);
            this.flaskGroupBox2.Size = new System.Drawing.Size(293, 130);
            this.flaskGroupBox2.TabIndex = 11;
            this.flaskGroupBox2.Titulo = "Analito";
            // 
            // ucAnalito
            // 
            this.ucAnalito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.ucAnalito.Consulta = null;
            this.ucAnalito.Location = new System.Drawing.Point(6, 28);
            this.ucAnalito.ManterFixo = false;
            this.ucAnalito.MaximumSize = new System.Drawing.Size(280, 95);
            this.ucAnalito.MinimumSize = new System.Drawing.Size(280, 95);
            this.ucAnalito.Name = "ucAnalito";
            this.ucAnalito.Reagente = null;
            this.ucAnalito.Size = new System.Drawing.Size(280, 95);
            this.ucAnalito.TabIndex = 2;
            this.ucAnalito.ReagenteChanged += new System.EventHandler(this.UcExcesso_ReagenteChanged);
            // 
            // flaskGroupBox1
            // 
            this.flaskGroupBox1.Controls.Add(this.ucExcesso);
            this.flaskGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flaskGroupBox1.Location = new System.Drawing.Point(146, 160);
            this.flaskGroupBox1.Name = "flaskGroupBox1";
            this.flaskGroupBox1.Padding = new System.Windows.Forms.Padding(3);
            this.flaskGroupBox1.Size = new System.Drawing.Size(293, 130);
            this.flaskGroupBox1.TabIndex = 10;
            this.flaskGroupBox1.Titulo = "Excesso";
            // 
            // ucExcesso
            // 
            this.ucExcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.ucExcesso.Consulta = null;
            this.ucExcesso.Location = new System.Drawing.Point(6, 28);
            this.ucExcesso.ManterFixo = false;
            this.ucExcesso.MaximumSize = new System.Drawing.Size(280, 95);
            this.ucExcesso.MinimumSize = new System.Drawing.Size(280, 95);
            this.ucExcesso.Name = "ucExcesso";
            this.ucExcesso.Reagente = null;
            this.ucExcesso.Size = new System.Drawing.Size(280, 95);
            this.ucExcesso.TabIndex = 2;
            this.ucExcesso.ReagenteChanged += new System.EventHandler(this.UcExcesso_ReagenteChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 47);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(126, 379);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(126, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblResultadoExcesso
            // 
            this.lblResultadoExcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoExcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoExcesso.Location = new System.Drawing.Point(445, 193);
            this.lblResultadoExcesso.Name = "lblResultadoExcesso";
            this.lblResultadoExcesso.Size = new System.Drawing.Size(159, 25);
            this.lblResultadoExcesso.TabIndex = 14;
            this.lblResultadoExcesso.Text = "Resultado:";
            this.lblResultadoExcesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flaskLabel2
            // 
            this.flaskLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flaskLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flaskLabel2.Location = new System.Drawing.Point(445, 219);
            this.flaskLabel2.Name = "flaskLabel2";
            this.flaskLabel2.Size = new System.Drawing.Size(159, 38);
            this.flaskLabel2.TabIndex = 15;
            this.flaskLabel2.Text = "Volume Reagido\r\n(Reagente em Excesso)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(445, 296);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 30);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // lblResultadoConcentracao
            // 
            this.lblResultadoConcentracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoConcentracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoConcentracao.Location = new System.Drawing.Point(445, 329);
            this.lblResultadoConcentracao.Name = "lblResultadoConcentracao";
            this.lblResultadoConcentracao.Size = new System.Drawing.Size(159, 25);
            this.lblResultadoConcentracao.TabIndex = 17;
            this.lblResultadoConcentracao.Text = "Resultado:";
            this.lblResultadoConcentracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flaskLabel4
            // 
            this.flaskLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flaskLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flaskLabel4.Location = new System.Drawing.Point(445, 355);
            this.flaskLabel4.Name = "flaskLabel4";
            this.flaskLabel4.Size = new System.Drawing.Size(159, 25);
            this.flaskLabel4.TabIndex = 18;
            this.flaskLabel4.Text = "Concentração do Analito";
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
            this.flaskButton3.Location = new System.Drawing.Point(436, 432);
            this.flaskButton3.Name = "flaskButton3";
            this.flaskButton3.Size = new System.Drawing.Size(168, 30);
            this.flaskButton3.TabIndex = 3;
            this.flaskButton3.Text = "Salvar Concentração";
            this.flaskButton3.UseVisualStyleBackColor = false;
            this.flaskButton3.Visible = false;
            this.flaskButton3.Click += new System.EventHandler(this.FlaskButton3_Click);
            // 
            // ucHeader1
            // 
            this.ucHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Location = new System.Drawing.Point(1, 1);
            this.ucHeader1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ucHeader1.MinimumSize = new System.Drawing.Size(330, 40);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.NaoEhFilho = false;
            this.ucHeader1.Size = new System.Drawing.Size(615, 40);
            this.ucHeader1.TabIndex = 1;
            this.ucHeader1.Titulo = "Retrotitulação";
            this.ucHeader1.Load += new System.EventHandler(this.ucHeader1_Load);
            // 
            // FrmRetrotitulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 468);
            this.Controls.Add(this.flaskButton3);
            this.Controls.Add(this.flaskLabel4);
            this.Controls.Add(this.lblResultadoConcentracao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.flaskLabel2);
            this.Controls.Add(this.lblResultadoExcesso);
            this.Controls.Add(this.flaskButton4);
            this.Controls.Add(this.flaskGroupBox3);
            this.Controls.Add(this.flaskGroupBox2);
            this.Controls.Add(this.flaskGroupBox1);
            this.Controls.Add(this.flaskButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucHeader1);
            this.Name = "FrmRetrotitulacao";
            this.Text = "Retrotitulação";
            this.Load += new System.EventHandler(this.FrmRetrotitulacao_Load);
            this.flaskGroupBox3.ResumeLayout(false);
            this.flaskGroupBox3.PerformLayout();
            this.flaskGroupBox2.ResumeLayout(false);
            this.flaskGroupBox2.PerformLayout();
            this.flaskGroupBox1.ResumeLayout(false);
            this.flaskGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcHeader ucHeader1;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton4;
        private FlaskUI.COMPONENTES.FlaskGroupBox flaskGroupBox3;
        private FlaskUI.COMPONENTES.FlaskLabel lblUnidadeTitulado;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel3;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton1;
        private FlaskUI.COMPONENTES.FlaskLabel lblVolumeTitulado;
        private FlaskUI.COMPONENTES.FlaskTextBox txtVolumeAnalito;
        private FlaskUI.COMPONENTES.FlaskTextBox txtVolumeExcesso;
        private FlaskUI.COMPONENTES.FlaskGroupBox flaskGroupBox2;
        private CONTROLES.UcFichaReagente ucAnalito;
        private FlaskUI.COMPONENTES.FlaskGroupBox flaskGroupBox1;
        private CONTROLES.UcFichaReagente ucExcesso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel1;
        private FlaskUI.COMPONENTES.FlaskLabel lblResultadoExcesso;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel2;
        private FlaskUI.COMPONENTES.FlaskButton btnCalcular;
        private FlaskUI.COMPONENTES.FlaskLabel lblResultadoConcentracao;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel4;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton3;
    }
}
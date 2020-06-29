namespace Flask.TELAS.CONTROLES
{
    partial class UcFichaReagente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFichaReagente));
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblNome = new FlaskUI.COMPONENTES.FlaskLabel();
            this.lblConcentracao = new FlaskUI.COMPONENTES.FlaskLabel();
            this.lblClasse = new FlaskUI.COMPONENTES.FlaskLabel();
            this.lblTipo = new FlaskUI.COMPONENTES.FlaskLabel();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbIcon
            // 
            this.pcbIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcon.Image")));
            this.pcbIcon.Location = new System.Drawing.Point(6, 5);
            this.pcbIcon.MaximumSize = new System.Drawing.Size(85, 85);
            this.pcbIcon.MinimumSize = new System.Drawing.Size(85, 85);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(85, 85);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            this.pcbIcon.Click += new System.EventHandler(this.PcbIcon_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.AutoScroll = true;
            this.pnlInfo.Controls.Add(this.lblNome);
            this.pnlInfo.Controls.Add(this.lblConcentracao);
            this.pnlInfo.Controls.Add(this.lblClasse);
            this.pnlInfo.Controls.Add(this.lblTipo);
            this.pnlInfo.Location = new System.Drawing.Point(97, 5);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(175, 85);
            this.pnlInfo.TabIndex = 6;
            this.pnlInfo.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 2);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Reagente";
            // 
            // lblConcentracao
            // 
            this.lblConcentracao.AutoSize = true;
            this.lblConcentracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConcentracao.Location = new System.Drawing.Point(3, 57);
            this.lblConcentracao.Name = "lblConcentracao";
            this.lblConcentracao.Size = new System.Drawing.Size(96, 17);
            this.lblConcentracao.TabIndex = 5;
            this.lblConcentracao.Text = "Concentração";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClasse.Location = new System.Drawing.Point(3, 39);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(131, 17);
            this.lblClasse.TabIndex = 2;
            this.lblClasse.Text = "Quantidade H⁺/OH⁻";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipo.Location = new System.Drawing.Point(3, 21);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(61, 5);
            this.btnRemover.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnRemover.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(30, 30);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "X";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // UcFichaReagente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pcbIcon);
            this.MaximumSize = new System.Drawing.Size(280, 95);
            this.MinimumSize = new System.Drawing.Size(280, 95);
            this.Name = "UcFichaReagente";
            this.Size = new System.Drawing.Size(280, 95);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbIcon;
        private FlaskUI.COMPONENTES.FlaskLabel lblNome;
        private FlaskUI.COMPONENTES.FlaskLabel lblClasse;
        private FlaskUI.COMPONENTES.FlaskLabel lblTipo;
        private FlaskUI.COMPONENTES.FlaskLabel lblConcentracao;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnRemover;
    }
}

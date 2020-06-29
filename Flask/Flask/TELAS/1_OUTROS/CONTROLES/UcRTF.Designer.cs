namespace Flask.TELAS.CONTROLES
{
    partial class UcRTF
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
            this.RTF = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flaskButton1 = new FlaskUI.COMPONENTES.FlaskButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTF
            // 
            this.RTF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RTF.Location = new System.Drawing.Point(0, 30);
            this.RTF.Name = "RTF";
            this.RTF.Size = new System.Drawing.Size(334, 120);
            this.RTF.TabIndex = 0;
            this.RTF.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flaskButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(334, 30);
            this.panel1.MinimumSize = new System.Drawing.Size(334, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 30);
            this.panel1.TabIndex = 1;
            // 
            // flaskButton1
            // 
            this.flaskButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flaskButton1.FlatAppearance.BorderSize = 0;
            this.flaskButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.flaskButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.flaskButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flaskButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flaskButton1.ForeColor = System.Drawing.Color.White;
            this.flaskButton1.Location = new System.Drawing.Point(3, 3);
            this.flaskButton1.Name = "flaskButton1";
            this.flaskButton1.Size = new System.Drawing.Size(64, 24);
            this.flaskButton1.TabIndex = 2;
            this.flaskButton1.Text = "Salvar";
            this.flaskButton1.UseVisualStyleBackColor = false;
            // 
            // UcRTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RTF);
            this.Controls.Add(this.panel1);
            this.Name = "UcRTF";
            this.Size = new System.Drawing.Size(334, 150);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox RTF;
        private System.Windows.Forms.Panel panel1;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton1;
    }
}

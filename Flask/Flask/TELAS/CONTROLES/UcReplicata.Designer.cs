namespace Flask.TELAS.CONTROLES
{
    partial class UcReplicata
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblValor = new FlaskUI.COMPONENTES.FlaskLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(125, 0);
            this.btnRemover.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnRemover.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(30, 30);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "X";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // lblValor
            // 
            this.lblValor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValor.Location = new System.Drawing.Point(0, 0);
            this.lblValor.MaximumSize = new System.Drawing.Size(110, 30);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(110, 30);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "100,00000";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValor.Click += new System.EventHandler(this.LblValor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(30, 30);
            this.panel1.MinimumSize = new System.Drawing.Size(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 10;
            this.panel1.Click += new System.EventHandler(this.LblValor_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox.Location = new System.Drawing.Point(9, 8);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 0;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // UcReplicata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnRemover);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(155, 30);
            this.MinimumSize = new System.Drawing.Size(155, 30);
            this.Name = "UcReplicata";
            this.Size = new System.Drawing.Size(155, 30);
            this.Click += new System.EventHandler(this.LblValor_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Panel panel1;
        internal FlaskUI.COMPONENTES.FlaskLabel lblValor;
        internal System.Windows.Forms.CheckBox checkBox;
    }
}

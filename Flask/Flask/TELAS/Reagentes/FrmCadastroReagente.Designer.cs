namespace Flask.TELAS.Reagentes
{
    partial class FrmCadastroReagente
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
            this.ucHeader1 = new Flask.TELAS.CONTROLES.UcHeader();
            this.SuspendLayout();
            // 
            // ucHeader1
            // 
            this.ucHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucHeader1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ucHeader1.MinimumSize = new System.Drawing.Size(400, 40);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.Size = new System.Drawing.Size(544, 40);
            this.ucHeader1.TabIndex = 0;
            this.ucHeader1.Titulo = "Cadastro de Reagente";
            // 
            // FrmCadastroReagente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(544, 611);
            this.Controls.Add(this.ucHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroReagente";
            this.Text = "FrmCadastroReagente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CONTROLES.UcHeader ucHeader1;
    }
}
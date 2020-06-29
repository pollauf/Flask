namespace Flask
{
    partial class FrmCarregando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarregando));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flaskLabel1 = new FlaskUI.COMPONENTES.FlaskLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flaskLabel1
            // 
            this.flaskLabel1.AutoSize = true;
            this.flaskLabel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.flaskLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.flaskLabel1.Location = new System.Drawing.Point(165, 62);
            this.flaskLabel1.Name = "flaskLabel1";
            this.flaskLabel1.Size = new System.Drawing.Size(144, 26);
            this.flaskLabel1.TabIndex = 3;
            this.flaskLabel1.Text = "Carregando...";
            // 
            // FrmCarregando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 150);
            this.Controls.Add(this.flaskLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarregando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarregando";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmCarregando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel1;
    }
}
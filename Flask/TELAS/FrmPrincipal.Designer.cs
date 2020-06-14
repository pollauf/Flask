namespace Flask.TELAS
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnAnalises = new System.Windows.Forms.Button();
            this.btnReagentes = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuLateral = new Flask.TELAS.CONTROLES.UcMenuLateral();
            this.ucAbas = new Flask.TELAS.CONTROLES.UcAbas();
            this.pnlMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnInfo);
            this.pnlMenu.Controls.Add(this.btnRelatorios);
            this.pnlMenu.Controls.Add(this.btnAnalises);
            this.pnlMenu.Controls.Add(this.btnReagentes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(150, 611);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(0, 450);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(150, 150);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.BackgroundImage")));
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 300);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(150, 150);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // btnAnalises
            // 
            this.btnAnalises.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnalises.BackgroundImage")));
            this.btnAnalises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnalises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalises.FlatAppearance.BorderSize = 0;
            this.btnAnalises.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnAnalises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnAnalises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalises.Location = new System.Drawing.Point(0, 150);
            this.btnAnalises.Name = "btnAnalises";
            this.btnAnalises.Size = new System.Drawing.Size(150, 150);
            this.btnAnalises.TabIndex = 4;
            this.btnAnalises.UseVisualStyleBackColor = true;
            this.btnAnalises.Click += new System.EventHandler(this.BtnAnalises_Click);
            // 
            // btnReagentes
            // 
            this.btnReagentes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReagentes.BackgroundImage")));
            this.btnReagentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReagentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReagentes.FlatAppearance.BorderSize = 0;
            this.btnReagentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnReagentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnReagentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReagentes.Location = new System.Drawing.Point(0, 0);
            this.btnReagentes.Name = "btnReagentes";
            this.btnReagentes.Size = new System.Drawing.Size(150, 150);
            this.btnReagentes.TabIndex = 3;
            this.btnReagentes.UseVisualStyleBackColor = true;
            this.btnReagentes.Click += new System.EventHandler(this.BtnReagentes_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(390, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(544, 581);
            this.pnlMain.TabIndex = 4;
            this.pnlMain.SizeChanged += new System.EventHandler(this.PnlMain_SizeChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(150, 0);
            this.MenuLateral.MaximumSize = new System.Drawing.Size(240, 0);
            this.MenuLateral.MinimumSize = new System.Drawing.Size(240, 80);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Opcoes = new string[] {
        "1",
        "2",
        "{title}Ácido-Base",
        "3"};
            this.MenuLateral.Size = new System.Drawing.Size(240, 611);
            this.MenuLateral.TabIndex = 3;
            this.MenuLateral.Titulo = "teste";
            this.MenuLateral.ButtonClick += new System.EventHandler(this.MenuLateral_ButtonClick);
            // 
            // ucAbas
            // 
            this.ucAbas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.ucAbas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucAbas.Location = new System.Drawing.Point(390, 0);
            this.ucAbas.MinimumSize = new System.Drawing.Size(200, 30);
            this.ucAbas.Name = "ucAbas";
            this.ucAbas.Size = new System.Drawing.Size(544, 30);
            this.ucAbas.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ucAbas);
            this.Controls.Add(this.MenuLateral);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flask";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnReagentes;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnAnalises;
        private System.Windows.Forms.Button btnInfo;
        private CONTROLES.UcMenuLateral MenuLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Panel pnlMain;
        internal CONTROLES.UcAbas ucAbas;
    }
}
namespace Flask.TELAS
{
    partial class FrmConsultaGeral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flaskDataGridView1 = new FlaskUI.COMPONENTES.FlaskDataGridView();
            this.flaskButton1 = new FlaskUI.COMPONENTES.FlaskButton();
            this.ucHeader1 = new Flask.UcHeader();
            ((System.ComponentModel.ISupportInitialize)(this.flaskDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flaskDataGridView1
            // 
            this.flaskDataGridView1.AllowUserToAddRows = false;
            this.flaskDataGridView1.AllowUserToDeleteRows = false;
            this.flaskDataGridView1.AllowUserToResizeColumns = false;
            this.flaskDataGridView1.AllowUserToResizeRows = false;
            this.flaskDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.flaskDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.flaskDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flaskDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.flaskDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flaskDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.flaskDataGridView1.EnableHeadersVisualStyles = false;
            this.flaskDataGridView1.Location = new System.Drawing.Point(1, 26);
            this.flaskDataGridView1.MultiSelect = false;
            this.flaskDataGridView1.Name = "flaskDataGridView1";
            this.flaskDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.flaskDataGridView1.RowHeadersVisible = false;
            this.flaskDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.flaskDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flaskDataGridView1.Size = new System.Drawing.Size(348, 256);
            this.flaskDataGridView1.TabIndex = 1;
            this.flaskDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlaskDataGridView1_CellDoubleClick);
            this.flaskDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlaskDataGridView1_KeyDown);
            // 
            // flaskButton1
            // 
            this.flaskButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flaskButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flaskButton1.FlatAppearance.BorderSize = 0;
            this.flaskButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.flaskButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.flaskButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flaskButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskButton1.ForeColor = System.Drawing.Color.White;
            this.flaskButton1.Location = new System.Drawing.Point(231, 288);
            this.flaskButton1.Name = "flaskButton1";
            this.flaskButton1.Size = new System.Drawing.Size(115, 30);
            this.flaskButton1.TabIndex = 2;
            this.flaskButton1.Text = "Selecionar";
            this.flaskButton1.UseVisualStyleBackColor = false;
            this.flaskButton1.Click += new System.EventHandler(this.FlaskButton1_Click);
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
            this.ucHeader1.Size = new System.Drawing.Size(348, 25);
            this.ucHeader1.TabIndex = 0;
            this.ucHeader1.Titulo = "Consulta Geral";
            // 
            // FrmConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 322);
            this.Controls.Add(this.flaskButton1);
            this.Controls.Add(this.flaskDataGridView1);
            this.Controls.Add(this.ucHeader1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(350, 0);
            this.Name = "FrmConsultaGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Geral";
            this.Load += new System.EventHandler(this.FrmConsultaGeral_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultaGeral_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.flaskDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcHeader ucHeader1;
        private FlaskUI.COMPONENTES.FlaskDataGridView flaskDataGridView1;
        private FlaskUI.COMPONENTES.FlaskButton flaskButton1;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flaskDataGridView1 = new FlaskUI.COMPONENTES.FlaskDataGridView();
            this.ucHeader1 = new Flask.UcHeader();
            this.flaskButton1 = new FlaskUI.COMPONENTES.FlaskButton();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.flaskDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.flaskDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flaskDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.flaskDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flaskDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.flaskDataGridView1.EnableHeadersVisualStyles = false;
            this.flaskDataGridView1.Location = new System.Drawing.Point(1, 41);
            this.flaskDataGridView1.MultiSelect = false;
            this.flaskDataGridView1.Name = "flaskDataGridView1";
            this.flaskDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.flaskDataGridView1.RowHeadersVisible = false;
            this.flaskDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.flaskDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flaskDataGridView1.Size = new System.Drawing.Size(459, 241);
            this.flaskDataGridView1.TabIndex = 1;
            this.flaskDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlaskDataGridView1_CellDoubleClick);
            this.flaskDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlaskDataGridView1_KeyDown);
            // 
            // ucHeader1
            // 
            this.ucHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Location = new System.Drawing.Point(1, 1);
            this.ucHeader1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ucHeader1.MinimumSize = new System.Drawing.Size(330, 40);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.Size = new System.Drawing.Size(459, 40);
            this.ucHeader1.TabIndex = 0;
            this.ucHeader1.Titulo = "Consulta Geral";
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
            this.flaskButton1.Location = new System.Drawing.Point(342, 288);
            this.flaskButton1.Name = "flaskButton1";
            this.flaskButton1.Size = new System.Drawing.Size(115, 30);
            this.flaskButton1.TabIndex = 2;
            this.flaskButton1.Text = "Selecionar";
            this.flaskButton1.UseVisualStyleBackColor = false;
            this.flaskButton1.Click += new System.EventHandler(this.FlaskButton1_Click);
            // 
            // FrmConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 322);
            this.Controls.Add(this.flaskButton1);
            this.Controls.Add(this.flaskDataGridView1);
            this.Controls.Add(this.ucHeader1);
            this.KeyPreview = true;
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
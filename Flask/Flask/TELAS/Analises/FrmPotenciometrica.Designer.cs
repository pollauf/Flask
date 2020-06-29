namespace Flask.TELAS.Analises
{
    partial class FrmPotenciometrica
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flaskDataGridView1 = new FlaskUI.COMPONENTES.FlaskDataGridView();
            this.clnVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flaskLabel1 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.txtVolume = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.txtpH = new FlaskUI.COMPONENTES.FlaskTextBox();
            this.flaskLabel2 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.flaskLabel3 = new FlaskUI.COMPONENTES.FlaskLabel();
            this.btnAdicionar = new FlaskUI.COMPONENTES.FlaskButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ucHeader1 = new Flask.UcHeader();
            ((System.ComponentModel.ISupportInitialize)(this.flaskDataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.flaskDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnVolume,
            this.clnH});
            this.flaskDataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flaskDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.flaskDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.flaskDataGridView1.EnableHeadersVisualStyles = false;
            this.flaskDataGridView1.Location = new System.Drawing.Point(16, 151);
            this.flaskDataGridView1.MultiSelect = false;
            this.flaskDataGridView1.Name = "flaskDataGridView1";
            this.flaskDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.flaskDataGridView1.RowHeadersVisible = false;
            this.flaskDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.flaskDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flaskDataGridView1.Size = new System.Drawing.Size(187, 211);
            this.flaskDataGridView1.TabIndex = 1;
            // 
            // clnVolume
            // 
            this.clnVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clnVolume.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnVolume.FillWeight = 116.7513F;
            this.clnVolume.HeaderText = "Volume (mL)";
            this.clnVolume.Name = "clnVolume";
            // 
            // clnH
            // 
            this.clnH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clnH.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnH.FillWeight = 83.24873F;
            this.clnH.HeaderText = "pH";
            this.clnH.Name = "clnH";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.RemoverToolStripMenuItem_Click);
            // 
            // flaskLabel1
            // 
            this.flaskLabel1.AutoSize = true;
            this.flaskLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel1.Location = new System.Drawing.Point(13, 56);
            this.flaskLabel1.Name = "flaskLabel1";
            this.flaskLabel1.Size = new System.Drawing.Size(138, 17);
            this.flaskLabel1.TabIndex = 2;
            this.flaskLabel1.Text = "Volume (adicionado)";
            // 
            // txtVolume
            // 
            this.txtVolume.Ativo = true;
            this.txtVolume.BackColor = System.Drawing.Color.White;
            this.txtVolume.CampoObrigatorio = true;
            this.txtVolume.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.NumeroReal;
            this.txtVolume.Erro = false;
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVolume.Location = new System.Drawing.Point(16, 76);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 23);
            this.txtVolume.TabIndex = 3;
            // 
            // txtpH
            // 
            this.txtpH.Ativo = true;
            this.txtpH.BackColor = System.Drawing.Color.White;
            this.txtpH.CampoObrigatorio = true;
            this.txtpH.DefinicaoCampo = FlaskUI.CLASSES.DefinicaoCampo.NumeroReal;
            this.txtpH.Erro = false;
            this.txtpH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtpH.Location = new System.Drawing.Point(16, 122);
            this.txtpH.Name = "txtpH";
            this.txtpH.Size = new System.Drawing.Size(100, 23);
            this.txtpH.TabIndex = 5;
            this.txtpH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtpH_KeyDown);
            // 
            // flaskLabel2
            // 
            this.flaskLabel2.AutoSize = true;
            this.flaskLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel2.Location = new System.Drawing.Point(13, 102);
            this.flaskLabel2.Name = "flaskLabel2";
            this.flaskLabel2.Size = new System.Drawing.Size(26, 17);
            this.flaskLabel2.TabIndex = 4;
            this.flaskLabel2.Text = "pH";
            // 
            // flaskLabel3
            // 
            this.flaskLabel3.AutoSize = true;
            this.flaskLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flaskLabel3.Location = new System.Drawing.Point(122, 79);
            this.flaskLabel3.Name = "flaskLabel3";
            this.flaskLabel3.Size = new System.Drawing.Size(27, 17);
            this.flaskLabel3.TabIndex = 6;
            this.flaskLabel3.Text = "mL";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(60)))), ((int)(((byte)(195)))));
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(137)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(122, 115);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(81, 30);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(209, 56);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(466, 306);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // ucHeader1
            // 
            this.ucHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Location = new System.Drawing.Point(1, 1);
            this.ucHeader1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ucHeader1.MinimumSize = new System.Drawing.Size(100, 40);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.NaoEhFilho = false;
            this.ucHeader1.Size = new System.Drawing.Size(683, 40);
            this.ucHeader1.TabIndex = 0;
            this.ucHeader1.Titulo = "Titulação Potenciométrica";
            // 
            // FrmPotenciometrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 388);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.flaskLabel3);
            this.Controls.Add(this.txtpH);
            this.Controls.Add(this.flaskLabel2);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.flaskLabel1);
            this.Controls.Add(this.flaskDataGridView1);
            this.Controls.Add(this.ucHeader1);
            this.Name = "FrmPotenciometrica";
            this.Text = "Titulação Potenciométrica";
            this.Load += new System.EventHandler(this.FrmPotenciometrica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flaskDataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcHeader ucHeader1;
        private FlaskUI.COMPONENTES.FlaskDataGridView flaskDataGridView1;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel1;
        private FlaskUI.COMPONENTES.FlaskTextBox txtVolume;
        private FlaskUI.COMPONENTES.FlaskTextBox txtpH;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel2;
        private FlaskUI.COMPONENTES.FlaskLabel flaskLabel3;
        private FlaskUI.COMPONENTES.FlaskButton btnAdicionar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnH;
    }
}
using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskUI.COMPONENTES
{
    public partial class FlaskDataGridView : DataGridView
    {
        public FlaskDataGridView()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.BackgroundColor = Color.White;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.EnableHeadersVisualStyles = false;
            this.MultiSelect = false;
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.AllowUserToAddRows = this.AllowUserToDeleteRows =
                this.AllowUserToResizeColumns = this.AllowUserToResizeRows = false;

            this.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(45, 54, 76),
                SelectionBackColor = Color.FromArgb(45, 54, 76),
                ForeColor = Color.White,
                Font = new Font("Calibri", 10, FontStyle.Bold),
            };

            this.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.White,
                SelectionBackColor = Color.FromArgb(90, 59, 137),
                ForeColor = Color.Black,
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
            };

            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            this.FormatarGrid();
        }
    }
}

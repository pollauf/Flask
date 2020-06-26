using FlaskUI.COMPONENTES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskUI.CLASSES
{
    public static class Extensao
    {
        public static void Carregar(this FlaskComboBox comboBox, string[] opcoes)
        {
            comboBox.DataSource = opcoes;
        }

        public static void FormatarGrid(this FlaskDataGridView flaskDataGridView)
        {
            foreach (DataGridViewColumn column in flaskDataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public static string FormatarString(this double str)
        {
            return str.ToString("0.00000");
        }
    }
}
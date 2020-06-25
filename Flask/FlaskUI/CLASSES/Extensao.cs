using FlaskUI.COMPONENTES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskUI.CLASSES
{
    public static class Extensao
    {
        public static void CarregarValores(this FlaskComboBox comboBox, IEnumerable<int> enumerable)
        {
            comboBox.Items.Clear();
            //comboBox.DataSource = Enum.GetValues(typeof(enumerable));
        }
    }
}
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

        public static string[] EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new NotImplementedException();

            IList<string> list = new List<string>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value.DescriptionAttr<T>());
                }
            }

            return list.ToArray();
        }

        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
    }
}
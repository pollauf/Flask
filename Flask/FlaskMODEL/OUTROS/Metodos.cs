using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlaskMODEL
{
    public static class Metodos
    {
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
                    list.Add(value.ObterDescricao<T>());
                }
            }

            return list.ToArray();
        }

        public static string ObterDescricao<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
    }
}

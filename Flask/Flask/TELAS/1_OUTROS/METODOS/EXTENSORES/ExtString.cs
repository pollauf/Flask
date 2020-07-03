using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public static class ExtString
    {
        public static string FormatarDataParaStringDeArquivo(this DateTime dateTime)
        {
            string strData = dateTime.ToString();

            strData = strData.Replace(" ", "_");
            strData = strData.Replace("/", "_");
            strData = strData.Replace("-", "_");
            strData = strData.Replace(":","_");
            strData = strData.Replace(",", "_");
            strData = strData.Replace("-", "_");

            return strData;
        }
    }
}

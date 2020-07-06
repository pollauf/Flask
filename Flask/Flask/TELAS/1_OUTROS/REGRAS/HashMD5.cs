using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public static class HashMD5
    {
        public static string Gerar(string valor)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(valor));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public static bool VerificarCredencial(string credencial, string hash)
        {
            string hashCredencial = Gerar(credencial);

            return CompararHashs(credencial, hash);
        }

        public static bool CompararHashs(string valor1, string valor2)
        {
            return valor1 == valor2;
        }
    }
}

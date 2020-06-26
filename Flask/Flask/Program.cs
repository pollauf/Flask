using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!File.Exists(@"C:\FLASK\DATA\BANCO.FDB"))
            {
                Directory.CreateDirectory(@"C:\FLASK\DATA");
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    db.Reagente.Add(new Reagente { ID = 1, Nome = "teste" });
                    db.SaveChanges();
                }             
            }                

            Application.Run(new TELAS.FrmPrincipal());
        }
    }
}

using Flask.TELAS.METODOS;
using FlaskMODEL;
using FlaskMODEL.TABELAS;
using FlaskUI.CLASSES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask
{
    public static class PotenciometriaDATA
    {
        public static bool Salvar(this Potenciometria model)
        {
            try
            {
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    var existente = db.Potenciometria.Where(x => x.TituladoID == model.TituladoID).FirstOrDefault();

                    if (existente == null)
                    {
                        Potenciometria oldestModel = db.Potenciometria.OrderByDescending(x => x.ID).FirstOrDefault();
                        model.ID = oldestModel == null ? 1 : oldestModel.ID + 1;

                        db.Entry(model).State = EntityState.Added;
                        db.Potenciometria.Add(model);
                    }
                    else
                    {
                        model.ID = existente.ID;
                        db.Entry(model).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                }

                MessageBox.Show($"Gráfico Potenciométrico anexado ao Reagente Nº {model.TituladoID.ToString("000000")} com sucesso.",
                    $"Gráfico Anexado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Excluir(this Potenciometria model)
        {
            try
            {
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    db.Entry(model).State = EntityState.Deleted;
                    db.SaveChanges();
                    //Tela.InformarExcluidoSucesso();
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string GerarString(this List<Potenciometrica> potenciometricas)
        {
            var _return = string.Empty;

            foreach (var item in potenciometricas)
                _return += $"{item.Volume.FormatarString()};{item.pH.FormatarString()}<br>";

            if (_return.EndsWith("<br>"))
                _return = _return.Substring(0, _return.Length - 4);

            _return = _return.Replace("<br>","\n");

            return _return;
        }

        public static List<Potenciometrica> GerarLista(this List<Potenciometrica> potenciometricas, string valores)
        {
            var _return = new List<Potenciometrica>();
            string[] linhas = valores.Split('\n').ToArray();

            foreach (var item in linhas)
            {
                string[] resultados = item.Split(';').ToArray();

                var volume = double.Parse(resultados[0]);
                var pH = double.Parse(resultados[1]);

                _return.Add(new Potenciometrica(volume, pH));
            }

            return _return;
        }
    }
}

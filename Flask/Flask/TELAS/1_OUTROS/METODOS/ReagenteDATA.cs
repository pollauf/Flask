using Flask.TELAS.METODOS;
using FlaskMODEL;
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
    public static class ReagenteDATA
    {
        public static bool Salvar(this Reagente model, Modo modo)
        {
            try
            {
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    if (modo == Modo.Novo)
                    {
                        Reagente oldestModel = db.Reagente.OrderByDescending(x => x.ID).FirstOrDefault();
                        model.ID = oldestModel == null ? 1 : oldestModel.ID + 1;

                        db.Entry(model).State = EntityState.Added;
                        db.Reagente.Add(model);
                    }
                    else if (modo == Modo.Alteracao)
                    {
                        db.Entry(model).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                }

                Tela.InformarSalvoSucesso();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Excluir(this Reagente model)
        {
            try
            {
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    var potenciometria = db.Potenciometria.Where(x => x.TituladoID == model.ID).FirstOrDefault();

                    db.Entry(model).State = EntityState.Deleted;
                    db.SaveChanges();

                    if (potenciometria != null)
                        potenciometria.Excluir();

                    Tela.InformarExcluidoSucesso();
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

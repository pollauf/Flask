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
    public static class RelatorioDATA
    {
        public static bool Salvar(this Relatorio model, Modo modo = Modo.Novo, bool abrirAposGerar = false)
        {
			try
			{
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    if (modo == Modo.Novo)
                    {
                        Relatorio oldestModel = db.Relatorio.OrderByDescending(x => x.ID).FirstOrDefault();     
                        model.ID = oldestModel == null ? 1 : oldestModel.ID + 1;
                        model.Data = DateTime.Now;

                        db.Entry(model).State = EntityState.Added;
                        db.Relatorio.Add(model);
                    }                       
                    else
                        db.Entry(model).State = EntityState.Modified;

                    db.SaveChanges();
                }

                var tipoAlteracao = modo == Modo.Novo ? "gerado" : "alterado";
                MessageBox.Show($"Registro Nº {model.ID.ToString("000000")} {tipoAlteracao} com sucesso.",
                    $"Relatório {tipoAlteracao}", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (abrirAposGerar)
                    Tela.Abrir(new FrmRelatorio(model.ID), "CADASTRO REGISTRO");

                return true;
			}
			catch (Exception)
			{
                MessageBox.Show("Erro de conexão com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
			}
        }

        public static bool Excluir(this Relatorio model)
        {
            try
            {
                using (FlaskDatabase db = new FlaskDatabase())
                {
                    db.Entry(model).State = EntityState.Deleted;
                    db.SaveChanges();
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

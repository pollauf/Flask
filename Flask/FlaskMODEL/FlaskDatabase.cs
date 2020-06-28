using FlaskMODEL.TABELAS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlaskMODEL
{
    public class FlaskDatabase : DbContext
    {
        public FlaskDatabase() : base("name=FlaskDatabase")
        {                        
            Database.SetInitializer(new CreateDatabaseIfNotExists<FlaskDatabase>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FlaskDatabase, Migrations.Configuration>());
        }
        public DbSet<Reagente> Reagente { get; set; }
        public DbSet<Relatorio> Relatorio { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}

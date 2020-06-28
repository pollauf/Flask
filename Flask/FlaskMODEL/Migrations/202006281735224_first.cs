namespace FlaskMODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reagentes",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Tipo = c.Int(nullable: false),
                        Forca = c.Int(nullable: false),
                        Classe = c.Int(nullable: false),
                        MassaMolar = c.Double(nullable: false),
                        Concentracao = c.Double(nullable: false),
                        KI1 = c.Double(nullable: false),
                        KI2 = c.Double(nullable: false),
                        KI3 = c.Double(nullable: false),
                        KI4 = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Relatorios",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Analise = c.String(),
                        Texto = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Relatorios");
            DropTable("dbo.Reagentes");
        }
    }
}

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
                        Valencia = c.Int(nullable: false),
                        Concentracao = c.Double(nullable: false),
                        ConstantesIonizacao = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reagentes");
        }
    }
}

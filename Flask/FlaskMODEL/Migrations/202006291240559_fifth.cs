namespace FlaskMODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Potenciometrias",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        TituladoID = c.Int(nullable: false),
                        DescricaoTitulante = c.String(),
                        Valores = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Potenciometrias");
        }
    }
}

namespace FlaskMODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reagentes", "Classe", c => c.Int(nullable: false));
            DropColumn("dbo.Reagentes", "Valencia");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reagentes", "Valencia", c => c.Int(nullable: false));
            DropColumn("dbo.Reagentes", "Classe");
        }
    }
}

namespace FlaskMODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reagentes", "KI1", c => c.Double(nullable: false));
            AddColumn("dbo.Reagentes", "KI2", c => c.Double(nullable: false));
            AddColumn("dbo.Reagentes", "KI3", c => c.Double(nullable: false));
            AddColumn("dbo.Reagentes", "KI4", c => c.Double(nullable: false));
            DropColumn("dbo.Reagentes", "ConstantesIonizacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reagentes", "ConstantesIonizacao", c => c.String());
            DropColumn("dbo.Reagentes", "KI4");
            DropColumn("dbo.Reagentes", "KI3");
            DropColumn("dbo.Reagentes", "KI2");
            DropColumn("dbo.Reagentes", "KI1");
        }
    }
}

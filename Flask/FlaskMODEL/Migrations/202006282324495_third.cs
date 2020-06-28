namespace FlaskMODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reagentes", "Formula", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reagentes", "Formula");
        }
    }
}

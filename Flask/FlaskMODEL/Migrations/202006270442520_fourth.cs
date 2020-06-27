﻿namespace FlaskMODEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reagentes", "MassaMolar", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reagentes", "MassaMolar");
        }
    }
}

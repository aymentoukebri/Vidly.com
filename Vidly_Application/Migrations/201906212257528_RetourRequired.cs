﻿namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RetourRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "Name", c => c.String(maxLength: 255));
        }
    }
}

namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Phone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "phone", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "phone", c => c.String(nullable: false, maxLength: 255));
        }
    }
}

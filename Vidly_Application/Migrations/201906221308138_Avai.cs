namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Avai : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "numberAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "numberAvailable", c => c.Int(nullable: false));
        }
    }
}

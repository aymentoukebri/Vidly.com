namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumberAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "numberAvailable", c => c.Int(nullable: false));
            Sql("update movies set numberAvailable = numberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "numberAvailable");
        }
    }
}

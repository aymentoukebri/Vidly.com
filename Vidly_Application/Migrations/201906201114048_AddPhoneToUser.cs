namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneToUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "phone", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "phone", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.AspNetUsers", "phone", c => c.String());
        }
    }
}

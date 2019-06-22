namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1996-06-15' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}

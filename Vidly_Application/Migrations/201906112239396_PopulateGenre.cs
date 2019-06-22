namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres values(1,'Comedy');");
            Sql("insert into Genres values(2,'Action');");
            Sql("insert into Genres values(3,'Family');");
            Sql("insert into Genres values(4,'Romance');");
        }
        
        public override void Down()
        {
        }
    }
}

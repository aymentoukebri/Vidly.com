namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idmovieint : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "movie_Id" });
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Rentals", "movie_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
            CreateIndex("dbo.Rentals", "movie_Id");
            AddForeignKey("dbo.Rentals", "movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "movie_Id" });
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Rentals", "movie_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
            CreateIndex("dbo.Rentals", "movie_Id");
            AddForeignKey("dbo.Rentals", "movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
        }
    }
}

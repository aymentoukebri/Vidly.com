namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutValeursNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name='Pay As You Go' where id=1;");
            Sql("UPDATE MembershipTypes set Name='Monthly' where id=2;");
            Sql("UPDATE MembershipTypes set Name='Quarterly' where id=3;");
            Sql("UPDATE MembershipTypes set Name='Annually' where id=4;");
        }
        
        public override void Down()
        {
        }
    }
}

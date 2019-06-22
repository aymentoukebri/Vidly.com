namespace Vidly_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'252b31f5-ef97-4e2d-87e6-22a7179dee54', N'guest@vidly.com', 0, N'AN7zuVBtqeRjIyaDV8rvoEVEl5AsJrNw/cCptz3TWB7Kzm7Q7Qw/QFgIXclckkj/5Q==', N'50838b49-fcf4-41f7-90bd-a647bd16066e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c424167-b94f-4b74-8daa-9b40d28fb7ce', N'admin@vidly.com', 0, N'AJx+/UbafNY5TyTkQxRKFY1B+vQGYCXx6G+47TDKZLN+V9Zxa+9zoRz1Y1lOWmpA5w==', N'8f0dfe74-012c-43ad-a8c8-1f5c38a61b2d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'17c6289f-c01d-4782-80cf-0f0d8b135938', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c424167-b94f-4b74-8daa-9b40d28fb7ce', N'17c6289f-c01d-4782-80cf-0f0d8b135938')

");
        }
        
        public override void Down()
        {
        }
    }
}

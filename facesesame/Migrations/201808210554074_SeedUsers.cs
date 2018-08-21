namespace facesesame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b92c171-e790-496f-aeb1-060ae2db759d', N'guest001@somemail.com', 0, N'ACvd+YEWe8dZ1Tds8KkqUoP1wMo4Uvk147ZOY2kWTqTpUwT+tAY8z2iDIcj37euc9g==', N'b9a0f54d-9932-4e22-ac96-7a02395edf40', NULL, 0, 0, NULL, 1, 0, N'guest001@somemail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd084dc54-a0f1-4791-acd8-773298c07bcf', N'admin@somemail.com', 0, N'ABWRZz4l8mrS8F8U6PfMBY9SiWTvlQn+qHpNTiWvpygsS7snYZN3h81pHHM5z/TBfQ==', N'53227556-1d4a-452f-a221-e2128f68def7', NULL, 0, 0, NULL, 1, 0, N'admin@somemail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'933d7615-358c-497e-a285-ba308897af46', N'CanAccessAll')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd084dc54-a0f1-4791-acd8-773298c07bcf', N'933d7615-358c-497e-a285-ba308897af46')

");
        }
        
        public override void Down()
        {
        }
    }
}

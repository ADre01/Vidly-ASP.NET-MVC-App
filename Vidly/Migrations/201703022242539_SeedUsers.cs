namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3448b1d7-094e-4df9-b900-1fab466d90fe', N'dre@dre.com', 0, N'AO7GDH5pcrkVHIV+63iMxIbPL5n35tpMT0Z8HoBJOQiwwdi6l12jFvgygyBPTOg6Kg==', N'5fac1801-cffa-4e79-8ca7-af399d101cc0', NULL, 0, 0, NULL, 1, 0, N'dre@dre.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4cdef4a5-a715-4eb3-9dea-21fdc719d232', N'admin@vidly.com', 0, N'AOTsBPOyYUhhI1hxn9PyvK1pFne7VJLIPOlqO5k+Fofh4XrJSqM4GxypnHyVITHjIg==', N'c5ff41f2-79c1-4506-9325-826dc8bf3f70', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4a98e19a-e727-49e7-ae1f-278a04c7c626', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4cdef4a5-a715-4eb3-9dea-21fdc719d232', N'4a98e19a-e727-49e7-ae1f-278a04c7c626')
                ");
        }
        
        public override void Down()
        {
        }
    }
}

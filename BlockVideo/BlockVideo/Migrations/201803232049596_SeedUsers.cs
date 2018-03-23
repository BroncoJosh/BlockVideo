namespace BlockVideo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'68ad289c-39ea-4782-9689-82ef89ea774a', N'admin@blockvideo.com', 0, N'AJKk/y85J/Gm2Z4yECpW4gCrcB/aSoyVsu/4hIXBtpIrPnNQ9W6156ecmjdIXVF3Tw==', N'b351a673-16ed-415b-837e-555abfad7abd', NULL, 0, 0, NULL, 1, 0, N'admin@blockvideo.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a109c910-b84b-48a8-8062-8fbe9e1471fc', N'guest@blockvideo.com', 0, N'AO+V2rJJahEvzQvkA+urFkus8qYXrnC0z2SU+KUqpicmpwUj3NeMLfTROOhrlsxp/w==', N'b427731a-3761-4171-9f74-961a6dcbf4d2', NULL, 0, 0, NULL, 1, 0, N'guest@blockvideo.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0ffae7e1-c2c1-4f57-b123-cef83b3ae6f2', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'68ad289c-39ea-4782-9689-82ef89ea774a', N'0ffae7e1-c2c1-4f57-b123-cef83b3ae6f2')

        ");
        }
        
        public override void Down()
        {
        }
    }
}

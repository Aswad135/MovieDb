namespace MovieDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Appearance",
                c => new
                    {
                        ActorId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ActorId, t.MovieId })
                .ForeignKey("dbo.Actor", t => t.ActorId, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.ActorId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        CoverPicture = c.String(),
                        TrailerLink = c.String(),
                        GenreName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genre", t => t.GenreName)
                .Index(t => t.GenreName);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                        UserID = c.String(maxLength: 128),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movie", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FavoriteGenre = c.String(maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genre", t => t.FavoriteGenre)
                .Index(t => t.FavoriteGenre)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Rating",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        UserID = c.String(maxLength: 128),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movie", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        movieid = c.Int(nullable: false),
                        userid = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.movieid, t.userid })
                .ForeignKey("dbo.Movie", t => t.movieid, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.userid, cascadeDelete: true)
                .Index(t => t.movieid)
                .Index(t => t.userid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Appearance", "MovieId", "dbo.Movie");
            DropForeignKey("dbo.Favorites", "userid", "dbo.AspNetUsers");
            DropForeignKey("dbo.Favorites", "movieid", "dbo.Movie");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Rating", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Rating", "MovieID", "dbo.Movie");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "FavoriteGenre", "dbo.Genre");
            DropForeignKey("dbo.Movie", "GenreName", "dbo.Genre");
            DropForeignKey("dbo.Comment", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comment", "MovieID", "dbo.Movie");
            DropForeignKey("dbo.Appearance", "ActorId", "dbo.Actor");
            DropIndex("dbo.Favorites", new[] { "userid" });
            DropIndex("dbo.Favorites", new[] { "movieid" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.Rating", new[] { "MovieID" });
            DropIndex("dbo.Rating", new[] { "UserID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "FavoriteGenre" });
            DropIndex("dbo.Comment", new[] { "MovieID" });
            DropIndex("dbo.Comment", new[] { "UserID" });
            DropIndex("dbo.Movie", new[] { "GenreName" });
            DropIndex("dbo.Appearance", new[] { "MovieId" });
            DropIndex("dbo.Appearance", new[] { "ActorId" });
            DropTable("dbo.Favorites");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Rating");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.Genre");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Comment");
            DropTable("dbo.Movie");
            DropTable("dbo.Appearance");
            DropTable("dbo.Actor");
        }
    }
}

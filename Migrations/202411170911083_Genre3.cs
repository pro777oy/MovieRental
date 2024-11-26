namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Genres", "GenreId", "dbo.Genres");
            DropIndex("dbo.Genres", new[] { "GenreId" });
            DropColumn("dbo.Genres", "GenreId");
            DropColumn("dbo.Genres", "DateAdded");
            DropColumn("dbo.Genres", "ReleaseDate");
            DropColumn("dbo.Genres", "NumberInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "NumberInStock", c => c.Byte(nullable: false));
            AddColumn("dbo.Genres", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Genres", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Genres", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Genres", "GenreId");
            AddForeignKey("dbo.Genres", "GenreId", "dbo.Genres", "Id");
        }
    }
}

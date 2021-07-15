namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "ReleaseDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Genres", "AddedTime", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "AddedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Genres", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}

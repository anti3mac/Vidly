namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumGenre_IdFromMovie : DbMigration
    {
        public override void Up()
        {
            DropColumn("Movies", "Genre_Id");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropStockInFromGenre : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Genres", "StockIn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "StockIn", c => c.Int(nullable: false));
        }
    }
}

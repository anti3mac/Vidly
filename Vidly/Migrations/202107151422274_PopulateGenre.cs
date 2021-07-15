namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genre (Id,Name,ReleaseDate,AddedTime,StockIn) Values (1,Comedy,1/1/1874,1/2/2011,10)");
            Sql("INSERT INTO Genre (Id,Name,ReleaseDate,AddedTime,StockIn) Values (2,Action,1/1/1854,1/2/2012,5)");
            Sql("INSERT INTO Genre (Id,Name,ReleaseDate,AddedTime,StockIn) Values (3,Horror,1/1/1904,1/2/2014,4)");
            Sql("INSERT INTO Genre (Id,Name,ReleaseDate,AddedTime,StockIn) Values (4,Fimly,1/1/1834,1/2/2021,8)");
            Sql("INSERT INTO Genre (Id,Name,ReleaseDate,AddedTime,StockIn) Values (5,Melo-Darama,1/1/1824,1/2/2016,15)");

        }
        
        public override void Down()
        {
        }
    }
}

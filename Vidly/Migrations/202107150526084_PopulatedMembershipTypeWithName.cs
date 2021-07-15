namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatedMembershipTypeWithName : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,Name) Values (9,0,0,Pay as You Go)");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,Name) Values (10,30,1,Monthly)");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,Name) Values (11,90,3,Monthly)");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,Name) Values (12,300,12,Yearly)");
        }
        
        public override void Down()
        {
        }
    }
}

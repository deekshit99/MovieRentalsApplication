namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipName1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name1 = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name1 = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name1 = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name1 = 'Half Yearly' WHERE Id = 4");
            Sql("UPDATE MembershipTypes SET Name1 = 'Annual' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}

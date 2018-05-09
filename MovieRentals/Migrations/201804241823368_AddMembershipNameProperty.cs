namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipNameProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name1");
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNameFromMembershipType : DbMigration
    {
        public override void Up()
        {
            DropColumn("db.MembershipTypes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }
    }
}

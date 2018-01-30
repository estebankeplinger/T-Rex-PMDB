namespace Portfolio_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rolenamechange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "userRole", c => c.String());
            DropColumn("dbo.AspNetUsers", "RoleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "RoleName", c => c.String());
            DropColumn("dbo.AspNetUsers", "userRole");
        }
    }
}

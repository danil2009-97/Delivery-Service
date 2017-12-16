namespace DeliveryServiceLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteUnnecessaryProperties : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "IsAdmin");
            DropColumn("dbo.Shops", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shops", "Address", c => c.String());
            AddColumn("dbo.Users", "IsAdmin", c => c.Boolean(nullable: false));
        }
    }
}

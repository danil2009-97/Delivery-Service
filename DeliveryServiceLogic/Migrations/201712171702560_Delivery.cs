namespace DeliveryServiceLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delivery : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "IsDelivered");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "IsDelivered", c => c.Boolean(nullable: false));
        }
    }
}

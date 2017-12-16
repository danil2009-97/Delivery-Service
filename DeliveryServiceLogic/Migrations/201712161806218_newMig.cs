namespace DeliveryServiceLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Shop_Id", c => c.Int());
            CreateIndex("dbo.Products", "Shop_Id");
            AddForeignKey("dbo.Products", "Shop_Id", "dbo.Shops", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Shop_Id", "dbo.Shops");
            DropIndex("dbo.Products", new[] { "Shop_Id" });
            DropColumn("dbo.Products", "Shop_Id");
        }
    }
}

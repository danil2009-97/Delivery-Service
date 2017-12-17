namespace DeliveryServiceLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "User_Id" });
            AddColumn("dbo.Orders", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "User_Id", c => c.Int());
            DropColumn("dbo.Orders", "UserId");
            CreateIndex("dbo.Orders", "User_Id");
            AddForeignKey("dbo.Orders", "User_Id", "dbo.Users", "Id");
        }
    }
}

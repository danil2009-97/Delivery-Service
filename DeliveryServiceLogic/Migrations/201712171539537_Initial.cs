namespace DeliveryServiceLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderedProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Product_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        LogoPath = c.String(),
                        Type_Id = c.Int(),
                        Shop_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.Type_Id)
                .ForeignKey("dbo.Shops", t => t.Shop_Id)
                .Index(t => t.Type_Id)
                .Index(t => t.Shop_Id);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderedTime = c.DateTime(nullable: false),
                        DeliveredTime = c.DateTime(nullable: false),
                        IsDelivered = c.Boolean(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rating = c.Double(nullable: false),
                        AvgCheck = c.Int(nullable: false),
                        LogoPath = c.String(),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopTypes", t => t.Type_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.ShopTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shops", "Type_Id", "dbo.ShopTypes");
            DropForeignKey("dbo.Products", "Shop_Id", "dbo.Shops");
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropForeignKey("dbo.OrderedProducts", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderedProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Type_Id", "dbo.ProductTypes");
            DropIndex("dbo.Shops", new[] { "Type_Id" });
            DropIndex("dbo.Orders", new[] { "User_Id" });
            DropIndex("dbo.Products", new[] { "Shop_Id" });
            DropIndex("dbo.Products", new[] { "Type_Id" });
            DropIndex("dbo.OrderedProducts", new[] { "Order_Id" });
            DropIndex("dbo.OrderedProducts", new[] { "Product_Id" });
            DropTable("dbo.ShopTypes");
            DropTable("dbo.Shops");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.OrderedProducts");
        }
    }
}

namespace DeliveryServiceLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class someFixes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "PhoneNumber", c => c.String());
            DropColumn("dbo.Products", "Weight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Weight", c => c.Double(nullable: false));
            AlterColumn("dbo.Users", "PhoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.Int(nullable: false));
        }
    }
}

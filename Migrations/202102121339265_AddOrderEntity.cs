namespace TelerikMvcTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(),
                        CustomerID = c.Int(),
                        Category_CategoryID = c.Int(),
                        Country_CountryID = c.Byte(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryID)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Category_CategoryID)
                .Index(t => t.Country_CountryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Byte(nullable: false),
                        CountryNameShort = c.String(),
                        CountryNameLong = c.String(),
                    })
                .PrimaryKey(t => t.CountryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Country_CountryID", "dbo.Countries");
            DropForeignKey("dbo.Orders", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "Country_CountryID" });
            DropIndex("dbo.Orders", new[] { "Category_CategoryID" });
            DropTable("dbo.Countries");
            DropTable("dbo.Orders");
        }
    }
}

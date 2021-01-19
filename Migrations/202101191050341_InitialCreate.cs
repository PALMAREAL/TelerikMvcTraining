namespace TelerikMvcTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        SupplierID = c.Int(),
                        CategoryID = c.Int(),
                        QuantityPerUnit = c.String(),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}

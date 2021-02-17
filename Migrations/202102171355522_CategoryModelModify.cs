namespace TelerikMvcTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryModelModify : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Country_CountryID", "dbo.Countries");
            DropIndex("dbo.Orders", new[] { "Country_CountryID" });
            DropPrimaryKey("dbo.Countries");
            AlterColumn("dbo.Categories", "Picture", c => c.Int());
            AlterColumn("dbo.Orders", "Country_CountryID", c => c.Int());
            AlterColumn("dbo.Countries", "CountryID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Countries", "CountryID");
            CreateIndex("dbo.Orders", "Country_CountryID");
            AddForeignKey("dbo.Orders", "Country_CountryID", "dbo.Countries", "CountryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Country_CountryID", "dbo.Countries");
            DropIndex("dbo.Orders", new[] { "Country_CountryID" });
            DropPrimaryKey("dbo.Countries");
            AlterColumn("dbo.Countries", "CountryID", c => c.Byte(nullable: false));
            AlterColumn("dbo.Orders", "Country_CountryID", c => c.Byte());
            AlterColumn("dbo.Categories", "Picture", c => c.Binary());
            AddPrimaryKey("dbo.Countries", "CountryID");
            CreateIndex("dbo.Orders", "Country_CountryID");
            AddForeignKey("dbo.Orders", "Country_CountryID", "dbo.Countries", "CountryID");
        }
    }
}

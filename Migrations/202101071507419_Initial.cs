namespace EntityUppgift.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campaigns",
                c => new
                    {
                        CampaignID = c.Int(nullable: false, identity: true),
                        CampaignName = c.String(),
                        Discount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CampaignID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Balance = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        ExpirationDate = c.Long(nullable: false),
                        TableofContent = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        PersonName = c.String(),
                        PersonNr = c.Long(nullable: false),
                        PhoneNr = c.Long(nullable: false),
                        HomeNr = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        InventoryID = c.Int(nullable: false, identity: true),
                        InventoryDate = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryID);
            
            CreateTable(
                "dbo.ProductCampaigns",
                c => new
                    {
                        Product_ProductID = c.Int(nullable: false),
                        Campaign_CampaignID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ProductID, t.Campaign_CampaignID })
                .ForeignKey("dbo.Products", t => t.Product_ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Campaigns", t => t.Campaign_CampaignID, cascadeDelete: true)
                .Index(t => t.Product_ProductID)
                .Index(t => t.Campaign_CampaignID);
            
            CreateTable(
                "dbo.InventoryPersons",
                c => new
                    {
                        Inventory_InventoryID = c.Int(nullable: false),
                        Person_PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Inventory_InventoryID, t.Person_PersonID })
                .ForeignKey("dbo.Inventories", t => t.Inventory_InventoryID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_PersonID, cascadeDelete: true)
                .Index(t => t.Inventory_InventoryID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.DepartmentProducts",
                c => new
                    {
                        Department_DepartmentID = c.Int(nullable: false),
                        Product_ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Department_DepartmentID, t.Product_ProductID })
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductID, cascadeDelete: true)
                .Index(t => t.Department_DepartmentID)
                .Index(t => t.Product_ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DepartmentProducts", "Product_ProductID", "dbo.Products");
            DropForeignKey("dbo.DepartmentProducts", "Department_DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.InventoryPersons", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.InventoryPersons", "Inventory_InventoryID", "dbo.Inventories");
            DropForeignKey("dbo.Departments", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.ProductCampaigns", "Campaign_CampaignID", "dbo.Campaigns");
            DropForeignKey("dbo.ProductCampaigns", "Product_ProductID", "dbo.Products");
            DropIndex("dbo.DepartmentProducts", new[] { "Product_ProductID" });
            DropIndex("dbo.DepartmentProducts", new[] { "Department_DepartmentID" });
            DropIndex("dbo.InventoryPersons", new[] { "Person_PersonID" });
            DropIndex("dbo.InventoryPersons", new[] { "Inventory_InventoryID" });
            DropIndex("dbo.ProductCampaigns", new[] { "Campaign_CampaignID" });
            DropIndex("dbo.ProductCampaigns", new[] { "Product_ProductID" });
            DropIndex("dbo.Departments", new[] { "Person_PersonID" });
            DropTable("dbo.DepartmentProducts");
            DropTable("dbo.InventoryPersons");
            DropTable("dbo.ProductCampaigns");
            DropTable("dbo.Inventories");
            DropTable("dbo.People");
            DropTable("dbo.Departments");
            DropTable("dbo.Products");
            DropTable("dbo.Campaigns");
        }
    }
}

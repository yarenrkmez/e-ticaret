namespace Hunerli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hunerli : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductsID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        ProductCast = c.Int(nullable: false),
                        exisT = c.Boolean(nullable: false),
                        ProductStocks = c.Int(nullable: false),
                        SellerName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.ProductsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}

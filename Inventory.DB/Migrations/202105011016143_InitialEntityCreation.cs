namespace Inventory.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialEntityCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InventoryMasters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false),
                        ItemDesc = c.String(),
                        ItemQty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InventoryMasters");
        }
    }
}

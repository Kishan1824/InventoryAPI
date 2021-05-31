namespace Inventory.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InventoryMasters", "ItemFile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InventoryMasters", "ItemFile");
        }
    }
}

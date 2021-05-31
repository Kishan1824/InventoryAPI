using System;
using System.Collections.Generic;
using System.Linq;
using Inventory.DB;
using Inventory.Entities;

namespace Inventory.Services
{
    public class InventoryMasterService : IInventoryMaster
    {
        public List<InventoryMaster> GetInventoryMasters()
        {
            using (var dbContext = new IMContext())
            {
                var inventoryItems = dbContext.InventoryMaster.ToList();
                return inventoryItems.ToList();
            }
        }

        public InventoryMaster GetInventoryMasterItem(int ID)
        {
            using (var dbContext = new IMContext())
            {
                return dbContext.InventoryMaster.Find(ID);
            }
        }

        public void SaveInventoryMaster(InventoryMaster inventoryMaster)
        {
            using (var dbContext = new IMContext())
            {
                dbContext.InventoryMaster.Add(inventoryMaster);
                dbContext.SaveChanges();
            }
        }

        public InventoryMaster DeleteInventoryMaster(int ID)
        {
            using (var dbContext = new IMContext())
            {
                var inventoryItem = dbContext.InventoryMaster.Find(ID);
                dbContext.InventoryMaster.Remove(inventoryItem);
                dbContext.SaveChanges();

                return inventoryItem;
            }
        }

        public void UpdateInventoryMaster(InventoryMaster inventoryMaster)
        {
            using (var dbContext = new IMContext())
            {
                InventoryMaster objData = dbContext.InventoryMaster.FirstOrDefault(x => x.ID == inventoryMaster.ID);
                objData.ItemName = inventoryMaster.ItemName;
                objData.ItemDesc = inventoryMaster.ItemDesc;
                objData.ItemPrice = inventoryMaster.ItemPrice;
                objData.ItemQty = inventoryMaster.ItemQty;
                objData.ItemFile = inventoryMaster.ItemFile;
                dbContext.SaveChanges();
            }
        }
    }
}

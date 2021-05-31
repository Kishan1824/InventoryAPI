using System.Collections.Generic;
using System.Linq;
using Inventory.Entities;

namespace Inventory.Services
{
    public interface IInventoryMaster
    {
        List<InventoryMaster> GetInventoryMasters();

        InventoryMaster GetInventoryMasterItem(int ID);

        void SaveInventoryMaster(InventoryMaster inventoryMaster);

        void UpdateInventoryMaster(InventoryMaster inventoryMaster);

        InventoryMaster DeleteInventoryMaster(int ID);
    }
}

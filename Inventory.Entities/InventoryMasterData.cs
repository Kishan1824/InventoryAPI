using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Entities
{
    public class InventoryMasterData
    {
        public InventoryMaster inventoryItems { get; set; }

        public List<InventoryMaster> inventoryItemsList { get; set; }
    }
}

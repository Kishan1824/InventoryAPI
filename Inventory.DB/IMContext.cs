using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Inventory.Entities;

namespace Inventory.DB
{
    public class IMContext : DbContext
    {
        public IMContext() : base("InventoryAppConn")
        {

        }
        public DbSet<InventoryMaster> InventoryMaster { get; set; }
    }
}

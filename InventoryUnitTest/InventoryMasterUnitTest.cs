using System.Collections.Generic;
using Xunit;
using Inventory.Services;
using Inventory.Entities;

namespace InventoryUnitTest
{
    public class InventoryMasterUnitTest
    {
        private readonly InventoryMasterService _service;
        
        public InventoryMasterUnitTest()
        {
            _service = new InventoryMasterService();
        }

        [Fact]
        public void GetInventoryMastersTest()
        {
            var okResult = _service.GetInventoryMasters();
            Assert.IsType<List<InventoryMaster>>(okResult as List<InventoryMaster>);
        }

        [Theory]
        [InlineData(1)]
        public void GetInventoryMasterItemTest(int id)
        {
            var okResult = _service.GetInventoryMasterItem(id);
            Assert.IsType<InventoryMaster>(okResult as InventoryMaster);
        }
    }
}

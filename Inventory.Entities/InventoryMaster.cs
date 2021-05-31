using System.ComponentModel.DataAnnotations;

namespace Inventory.Entities
{
    public class InventoryMaster
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="mandatory")]
        public string ItemName { get; set; }    
        
        public string ItemDesc { get; set; }

        [Required(ErrorMessage = "mandatory")]
        public decimal ItemQty { get; set; }

        [Required(ErrorMessage = "mandatory")]
        public decimal ItemPrice { get; set; }

        public string ItemFile { get; set; }
    }
}

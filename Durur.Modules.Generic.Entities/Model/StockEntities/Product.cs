using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Product : DateLogEntity
    {
        public Product()
        {
            Stock_Warehouses = new Collection<Inventory>();
        }

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_ID { get; set; }

        [StringLength(50)]
        [Required]
        public string Product_Name { get; set; }

        public string Product_Description { get; set; }

        public int Warranty_Period { get; set; }

        [Column(TypeName = "money")]
        [Required]
        public decimal List_Price { get; set; }

        public Supplier Supplier { get; set; }

        public ICollection<Inventory> Stock_Warehouses { get; set; }
    }
}

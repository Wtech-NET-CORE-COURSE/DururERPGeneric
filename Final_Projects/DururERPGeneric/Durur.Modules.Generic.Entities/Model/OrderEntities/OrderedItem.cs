using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class OrderedItem
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ordered_Item_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal Unit_Price { get; set; }

        public int Quantity { get; set; }


        public Order Order { get; set; }

        public Product Product { get; set; }

        public Inventory Inventory { get; set; }
    }
}

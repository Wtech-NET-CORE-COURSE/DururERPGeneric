using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Inventory : DateLogEntity
    {

        [Column(Order = 0), Key, ForeignKey("Warehouse")]
        public int Warehouse_ID { get; set; }

        [Column(Order = 1), Key, ForeignKey("Product")]
        public int Product_ID { get; set; }

        public int QuantityOnHand { get; set; }

        public Warehouse Warehouse { get; set; }

        public Product Product { get; set; }

    }
}

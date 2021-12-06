using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Order : DateLogEntity
    {
        public Order()
        {
            Ordered_Items = new Collection<OrderedItem>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal Order_Total { get; set; }

        public OrderStatus Order_Status { get; set; }

        public Customer Customer { get; set; }

        public CustomerAddress Delivery_Address { get; set; }

        public ICollection<OrderedItem> Ordered_Items { get; set; }


    }
}

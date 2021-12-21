using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class CustomerAddress : DateLogEntity
    {
        public CustomerAddress()
        {
            Orders = new Collection<Order>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerAddress_ID { get; set; }

        public string Address { get; set; }

        public Location Location { get; set; }

        public Customer Customer { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Customer : DateLogEntity
    {
        public Customer()
        {
            Customer_Addresses = new Collection<CustomerAddress>();
            Orders = new Collection<Order>();
        }

        [Key, ForeignKey("User")]
        public int Customer_ID { get; set; }

        [StringLength(20)]
        [Required]
        public string First_Name { get; set; }

        [StringLength(20)]
        [Required]
        public string Last_Name { get; set; }

        [StringLength(14)]
        [Required]
        public string Primary_Phone_Number { get; set; }

        [StringLength(14)]
        public string Secondary_Phone_Number { get; set; }

        public bool Gender { get; set; }

        public User User { get; set; }

        public ICollection<CustomerAddress> Customer_Addresses { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}

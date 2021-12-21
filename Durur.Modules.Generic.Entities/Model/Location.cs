using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Location
    {
        public Location()
        {
            Departments = new Collection<Department>();
            Warehouses = new Collection<Warehouse>();
            Customer_Addresses = new Collection<CustomerAddress>();
        }

        public int Location_ID { get; set; }

        public string City { get; set; }

        public Country Country { get; set; }

        public ICollection<Department> Departments { get; set; }

        public ICollection<Warehouse> Warehouses { get; set; }

        public ICollection<CustomerAddress> Customer_Addresses { get; set; }

    }
}

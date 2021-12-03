using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Warehouse : DateLogEntity
    {
        public Warehouse()
        {
            Stock_Products = new Collection<Inventory>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Warehouse_ID { get; set; }

        [StringLength(30)]
        public string Warehouse_Name { get; set; }

        public Location Location { get; set; }

        public ICollection<Inventory> Stock_Products { get; set; }

    }
}

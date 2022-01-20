using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Supplier : DateLogEntity
    {

        public Supplier()
        {
            Supplied_Products = new Collection<Product>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Supplier_ID { get; set; }

        [StringLength(50)]
        public string Supplier_Name { get; set; }

        [ForeignKey("Location")]
        public int Location_ID { get; set; }
        public Location Location { get; set; }

        public ICollection<Product> Supplied_Products { get; set; }

    }
}

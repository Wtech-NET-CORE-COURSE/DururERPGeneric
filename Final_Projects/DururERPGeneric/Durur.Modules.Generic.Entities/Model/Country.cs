using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Country
    {
        public Country()
        {
            Locations = new Collection<Location>();
        }

        public int Country_ID { get; set; }

        [Column(TypeName ="char(2)")]
        [Required]
        public string ISO_Code { get; set; }

        public string Country_Name { get; set; }

        public int Phone_Code { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class OrderStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_Status_ID { get; set; }

        [StringLength(20)]
        public string Order_Current_Status { get; set; }
    }
}

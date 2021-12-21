using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class CompanyPosition
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Company_Position_ID { get; set; }
        [StringLength(30)]
        [Required]
        public string Company_Position_Name { get; set; }
        [Required]
        public string Company_Position_Description { get; set; }

        public EmployeeCompanyPosition EmployeeCompanyPosition { get; set; }
    }
}

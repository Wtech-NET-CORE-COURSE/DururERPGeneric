using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Employee : DateLogEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Employee_ID { get; set; }

        [StringLength(30)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(20)]
        [Required]
        public string LastName { get; set; }

        [StringLength(60)]
        public string EMail { get; set; }

        [StringLength(14)]
        [Required]
        public string Phone_Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime Hire_Date { get; set; }

        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        public Employee EmployeeMaster { get; set; }

        public Job Job { get; set; }

        public EmployeeCompanyPosition Position { get; set; }


    }
}

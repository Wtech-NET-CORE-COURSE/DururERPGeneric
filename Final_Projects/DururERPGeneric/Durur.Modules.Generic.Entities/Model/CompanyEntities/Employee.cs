using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Employee : DateLogEntity
    {
        public int Employee_ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EMail { get; set; }

        public string Phone_Number { get; set; }

        public DateTime Hire_Date { get; set; }

        public decimal Salary { get; set; }

        public Employee EmployeeMaster { get; set; }

        public Job Job { get; set; }

        public EmployeeCompanyPosition Position { get; set; }


    }
}

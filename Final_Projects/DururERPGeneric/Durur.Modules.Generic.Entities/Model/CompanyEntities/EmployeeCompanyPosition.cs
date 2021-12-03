using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class EmployeeCompanyPosition : DateLogEntity
    {
        public EmployeeCompanyPosition()
        {
            Employees = new Collection<Employee>();
            Positions = new Collection<CompanyPosition>();
            Departments = new Collection<Department>();
        }


        [Column(Order = 0), Key, ForeignKey("Department")]
        public int Department_ID { get; set; }

        [Column(Order = 1), Key, ForeignKey("Position")]
        public int Position_ID { get; set; }
        [Column(Order = 2), Key, ForeignKey("Employee")]
        public int Employee_ID { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<CompanyPosition> Positions { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}

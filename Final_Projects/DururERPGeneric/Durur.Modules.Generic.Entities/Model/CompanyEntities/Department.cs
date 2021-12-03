using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Department : DateLogEntity
    {
        public int Department_ID { get; set; }

        public string Department_Name { get; set; }
        
        public Location Location { get; set; }

        public EmployeeCompanyPosition EmployeePositions { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class Job
    {
        public Job()
        {
            Employees = new Collection<Employee>();
        }

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Job_ID { get; set; }

        [StringLength(50)]
        public string Job_Title { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

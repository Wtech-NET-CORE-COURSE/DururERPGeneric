using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ErpGenericDbContext context) : base(context) { }

        public async Task<Department> GetDepartmentByName(string name)
        {
            var department = await Context.Departments.FirstOrDefaultAsync(d => d.Department_Name == name);
            return department;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsByLocationIDAsync(int locationId)
        {
            var departments = await Context.Departments.Where(d => d.Location.Location_ID == locationId).ToListAsync();
            return departments;
        }
    }
}

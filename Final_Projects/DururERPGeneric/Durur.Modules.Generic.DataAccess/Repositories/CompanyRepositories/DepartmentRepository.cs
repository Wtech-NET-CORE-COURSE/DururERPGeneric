using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ErpGenericDbContext context) : base(context) { }

        public Department GetDepartmentByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetDepartmentsByLocationIDAsync(int locationId)
        {
            throw new NotImplementedException();
        }
    }
}

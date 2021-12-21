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
    public class EmployeeCompanyPositionRepository : Repository<EmployeeCompanyPosition>,IEmployeeCompanyPositionRepository
    {
        public EmployeeCompanyPositionRepository(ErpGenericDbContext context) : base(context) { }

        public async Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByCompanyPositionIDAsync(int companyPositionId)
        {
            var positions = await Context.Employee_CompanyPositions.Where(e => e.Position_ID == companyPositionId).ToListAsync();
            return positions;
        }

        public async Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByDepartmentIDAsync(int departmentId)
        {
            var positions = await Context.Employee_CompanyPositions.Where(e => e.Department_ID == departmentId).ToListAsync();
            return positions;
        }

        public async Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByEmployeeIDAsync(int employeeId)
        {
            var positions = await Context.Employee_CompanyPositions.Where(e => e.Employee_ID == employeeId).ToListAsync();
            return positions;
        }
    }
}

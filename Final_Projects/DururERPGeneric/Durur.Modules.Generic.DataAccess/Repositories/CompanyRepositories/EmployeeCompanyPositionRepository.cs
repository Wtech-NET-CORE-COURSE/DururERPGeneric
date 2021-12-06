using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class EmployeeCompanyPositionRepository : Repository<EmployeeCompanyPosition>,IEmployeeCompanyPositionRepository
    {
        public EmployeeCompanyPositionRepository(ErpGenericDbContext context) : base(context) { }

        public Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByCompanyPositionIDAsync(int companyPositionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByDepartmentIDAsync(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByEmployeeIDAsync(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}

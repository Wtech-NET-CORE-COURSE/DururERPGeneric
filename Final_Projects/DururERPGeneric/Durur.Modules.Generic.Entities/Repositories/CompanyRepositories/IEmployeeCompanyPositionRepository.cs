using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Entities.Repositories
{
    public interface IEmployeeCompanyPositionRepository : IRepository<EmployeeCompanyPosition>
    {

        Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByEmployeeIDAsync(int employeeId);

        Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByDepartmentIDAsync(int departmentId);

        Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByCompanyPositionIDAsync(int companyPositionId);

    }
}

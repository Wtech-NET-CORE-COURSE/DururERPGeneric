using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IEmployeeCompanyPositionServices
    {
        Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeeCompanyPositionsAsync();

        Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByEmployeeIDAsync(int employeeId);

        Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByDepartmentIDAsync(int departmentId);

        Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByCompanyPositionIDAsync(int companyPositionId);

        Task AddEmployeePosition(EmployeeCompanyPosition employeeCompanyPosition);
        Task AddEmployeePositionRange(IEnumerable<EmployeeCompanyPosition> employeeCompanyPositions);

        Task RemoveEmployeePosition(EmployeeCompanyPosition employeeCompanyPosition);
        Task RemoveEmployeePositionRange(IEnumerable<EmployeeCompanyPosition> employeeCompanyPositions);

    }
}

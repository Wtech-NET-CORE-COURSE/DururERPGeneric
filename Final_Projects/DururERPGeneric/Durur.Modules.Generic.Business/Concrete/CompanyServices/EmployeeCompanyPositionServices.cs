using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class EmployeeCompanyPositionServices : IEmployeeCompanyPositionServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeCompanyPositionServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddEmployeePosition(EmployeeCompanyPosition employeeCompanyPosition)
        {
            throw new NotImplementedException();
        }

        public void AddEmployeePositionRange(IEnumerable<EmployeeCompanyPosition> employeeCompanyPositions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeeCompanyPositionsAsync()
        {
            throw new NotImplementedException();
        }

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

        public Task RemoveEmployeePosition(EmployeeCompanyPosition employeeCompanyPosition)
        {
            throw new NotImplementedException();
        }

        public Task RemoveEmployeePositionRange(IEnumerable<EmployeeCompanyPosition> employeeCompanyPositions)
        {
            throw new NotImplementedException();
        }
    }
}

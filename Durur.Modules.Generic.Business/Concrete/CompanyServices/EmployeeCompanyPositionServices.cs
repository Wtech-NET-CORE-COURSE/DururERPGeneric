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

        public async Task AddEmployeePosition(EmployeeCompanyPosition employeeCompanyPosition)
        {
            await _unitOfWork.EmployeeCompanyPositions.AddAsync(employeeCompanyPosition);
        }

        public async Task AddEmployeePositionRange(IEnumerable<EmployeeCompanyPosition> employeeCompanyPositions)
        {
            await _unitOfWork.EmployeeCompanyPositions.AddRangeAsync(employeeCompanyPositions);
        }

        public async Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeeCompanyPositionsAsync()
        {
            var positions = await _unitOfWork.EmployeeCompanyPositions.GetAllAsync();
            return positions;
        }

        public async Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByCompanyPositionIDAsync(int companyPositionId)
        {
            var positions = await _unitOfWork.EmployeeCompanyPositions.GetEmployeePositionsByCompanyPositionIDAsync(companyPositionId);
            return positions;
        }

        public async Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByDepartmentIDAsync(int departmentId)
        {
            var positions = await _unitOfWork.EmployeeCompanyPositions.GetEmployeePositionsByDepartmentIDAsync(departmentId);
            return positions;
        }

        public async Task<IEnumerable<EmployeeCompanyPosition>> GetEmployeePositionsByEmployeeIDAsync(int employeeId)
        {
            var positions = await _unitOfWork.EmployeeCompanyPositions.GetEmployeePositionsByEmployeeIDAsync(employeeId);
            return positions;
        }

        public async Task RemoveEmployeePosition(EmployeeCompanyPosition employeeCompanyPosition)
        {
            _unitOfWork.EmployeeCompanyPositions.Remove(employeeCompanyPosition);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveEmployeePositionRange(IEnumerable<EmployeeCompanyPosition> employeeCompanyPositions)
        {
            _unitOfWork.EmployeeCompanyPositions.RemoveRange(employeeCompanyPositions);
            await _unitOfWork.CommitAsync();
        }
    }
}

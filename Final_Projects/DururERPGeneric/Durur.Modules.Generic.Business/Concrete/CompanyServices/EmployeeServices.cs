using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _unitOfWork.Employees.AddAsync(employee);
        }

        public async Task AddEmployeeRangeAsync(IEnumerable<Employee> employees)
        {
            await _unitOfWork.Employees.AddRangeAsync(employees);
        }

        public async Task<Employee> GetEmployeeByIDAsync(int id)
        {
            var employee = await _unitOfWork.Employees.GetByIDAsync(id);
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            var employees = await _unitOfWork.Employees.GetAllAsync();
            return employees;
        }

        public async Task RemoveEmployee(int id)
        {
            _unitOfWork.Employees.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveEmployee(Employee employee)
        {
            _unitOfWork.Employees.Remove(employee);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveEmployeeRange(IEnumerable<Employee> employees)
        {
            _unitOfWork.Employees.RemoveRange(employees);
            await _unitOfWork.CommitAsync();
        }

        public Employee UpdateEmployee(Employee employeeToUpdate, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

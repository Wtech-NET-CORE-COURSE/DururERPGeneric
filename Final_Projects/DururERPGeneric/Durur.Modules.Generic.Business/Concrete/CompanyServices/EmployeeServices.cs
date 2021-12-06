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

        public Task AddEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task AddEmployeeRangeAsync(IEnumerable<Employee> employees)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployeeRange(IEnumerable<Employee> employees)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(Employee employeeToUpdate, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

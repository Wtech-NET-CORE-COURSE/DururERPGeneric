using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IEmployeeServices
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeByIDAsync(int id);

        Task AddEmployeeAsync(Employee employee);

        Task AddEmployeeRangeAsync(IEnumerable<Employee> employees);

        Employee UpdateEmployee(Employee employeeToUpdate,Employee employee);

        void RemoveEmployee(int id);

        void RemoveEmployee(Employee employee);

        void RemoveEmployeeRange(IEnumerable<Employee> employees);
    }
}

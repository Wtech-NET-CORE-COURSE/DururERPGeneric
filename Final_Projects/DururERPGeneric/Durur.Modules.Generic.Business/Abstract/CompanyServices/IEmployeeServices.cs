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

        Task RemoveEmployee(int id);

        Task RemoveEmployee(Employee employee);

        Task RemoveEmployeeRange(IEnumerable<Employee> employees);
    }
}

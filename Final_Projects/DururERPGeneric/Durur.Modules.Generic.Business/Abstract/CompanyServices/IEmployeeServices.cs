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

        Employee GetEmployeeByID(int id);

        void AddEmployee(Employee employee);

        Employee UpdateEmployee(Employee employee);

        void DeleteEmployee(int id);
    }
}

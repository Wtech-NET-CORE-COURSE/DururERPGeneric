using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IDepartmentServices
    {
        Task<IEnumerable<Department>> GetDepartmentsAsync();

        Task<Department> GetDepartmentByIDAsync(int id);

        Task<IEnumerable<Department>> GetDepartmentsByLocationIDAsync(int locationId);

        Task<Department> GetDepartmentByName(string name);

        Task AddDepartmentAsync(Department department);

        Task AddDepartmentRangeAsync(IEnumerable<Department> departments);

        Department UpdateDepartment(Department departmentToUpdate, Department department);

        void RemoveDepartment(int id);

        void RemoveDepartment(Department department);

    }
}

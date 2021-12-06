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

        Department GetDepartmentByID(int id);

        Task<IEnumerable<Department>> GetDepartmentsByLocationIDAsync(int locationId);

        Department GetDepartmentByName(string name);

        void AddDepartment(Department department);

        Department UpdateDepartment(Department department);

        void DeleteDepartment(int id);
    }
}

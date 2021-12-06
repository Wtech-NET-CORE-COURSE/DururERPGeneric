using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class DepartmentServices : IDepartmentServices
    {
        public Task AddDepartmentAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Task AddDepartmentRangeAsync(IEnumerable<Department> departments)
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartmentByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartmentByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetDepartmentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetDepartmentsByLocationIDAsync(int locationId)
        {
            throw new NotImplementedException();
        }

        public void RemoveDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public Department UpdateDepartment(Department departmentToUpdate, Department department)
        {
            throw new NotImplementedException();
        }
    }
}

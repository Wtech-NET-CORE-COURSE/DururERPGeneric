using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddDepartmentAsync(Department department)
        {
            await _unitOfWork.Departments.AddAsync(department);
        }

        public async Task AddDepartmentRangeAsync(IEnumerable<Department> departments)
        {
            await _unitOfWork.Departments.AddRangeAsync(departments);
        }

        public async Task<Department> GetDepartmentByIDAsync(int id)
        {
            var department = await _unitOfWork.Departments.GetByIDAsync(id);
            return department;
        }

        public async Task<Department> GetDepartmentByName(string name)
        {
            var department = await _unitOfWork.Departments.GetDepartmentByName(name);
            return department;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsAsync()
        {
            var departments = await _unitOfWork.Departments.GetAllAsync();
            return departments;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsByLocationIDAsync(int locationId)
        {
            var departments = await _unitOfWork.Departments.GetDepartmentsByLocationIDAsync(locationId);
            return departments;
        }

        public async Task RemoveDepartment(int id)
        {
            _unitOfWork.Departments.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveDepartment(Department department)
        {
            _unitOfWork.Departments.Remove(department);
            await _unitOfWork.CommitAsync();
        }

        public Department UpdateDepartment(Department departmentToUpdate, Department department)
        {
            throw new NotImplementedException();
        }
    }
}

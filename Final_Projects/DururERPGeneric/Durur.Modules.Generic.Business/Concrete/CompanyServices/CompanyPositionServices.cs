using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class CompanyPositionServices : ICompanyPositionServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyPositionServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task AddCompanyPositionAsync(CompanyPosition companyPosition)
        {
            await _unitOfWork.CompanyPositions.AddAsync(companyPosition);
        }


        public async Task AddCompanyPositionRangeAsync(IEnumerable<CompanyPosition> companyPositions)
        {
            await _unitOfWork.CompanyPositions.AddRangeAsync(companyPositions);
            await _unitOfWork.CommitAsync();
        }

        public async Task<CompanyPosition> GetCompanyPositionByIDAsync(int id)
        {
            var companyPosition=await _unitOfWork.CompanyPositions.GetByIDAsync(id);
            return companyPosition;
        }

        public async Task<IEnumerable<CompanyPosition>> GetCompanyPositionsAsync()
        {
            var companyPositions = await _unitOfWork.CompanyPositions.GetAllAsync();
            return companyPositions;
        }

        public async Task RemoveCompanyPosition(int id)
        {
            _unitOfWork.CompanyPositions.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveCompanyPosition(CompanyPosition companyPosition)
        {
            _unitOfWork.CompanyPositions.Remove(companyPosition);
            await _unitOfWork.CommitAsync();
        }


        public async Task UpdateCompanyPosition(CompanyPosition companyPositionToBeUpdated, CompanyPosition companyPosition)
        {
            companyPositionToBeUpdated.Company_Position_Name = companyPosition.Company_Position_Name;
            companyPositionToBeUpdated.Company_Position_Description = companyPosition.Company_Position_Description;
            await _unitOfWork.CommitAsync();
        }
    }
}

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
            throw new NotImplementedException();
        }


        public async Task AddCompanyPositionsAsync(IEnumerable<CompanyPosition> companyPositions)
        {
            throw new NotImplementedException();
        }

        public async Task<CompanyPosition> GetCompanyPositionByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CompanyPosition>> GetCompanyPositionsAsync()
        {
            throw new NotImplementedException();
        }

        public void RemoveCompanyPosition(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCompanyPosition(CompanyPosition companyPosition)
        {
            throw new NotImplementedException();
        }


        public CompanyPosition UpdateCompanyPosition(CompanyPosition companyPositionToUpdated, CompanyPosition companyPosition)
        {
            throw new NotImplementedException();
        }
    }
}

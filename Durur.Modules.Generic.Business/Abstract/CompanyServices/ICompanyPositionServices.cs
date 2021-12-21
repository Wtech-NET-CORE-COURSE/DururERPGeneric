using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface ICompanyPositionServices
    {
        Task<IEnumerable<CompanyPosition>> GetCompanyPositionsAsync();

        Task<CompanyPosition> GetCompanyPositionByIDAsync(int id);

        Task AddCompanyPositionAsync(CompanyPosition companyPosition);

        Task UpdateCompanyPosition(CompanyPosition companyPositionToBeUpdated, CompanyPosition companyPosition);

        Task RemoveCompanyPosition(int id);

        Task RemoveCompanyPosition(CompanyPosition companyPosition);
    }
}

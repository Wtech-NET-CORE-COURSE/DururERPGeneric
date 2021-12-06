using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface ICompanyPositionServices
    {
        Task<IEnumerable<CompanyPosition>> GetCompanyPositionsAsync();

        CompanyPosition GetCompanyPositionByID(int id);

        void AddCompanyPosition(CompanyPosition companyPosition);

        CompanyPosition UpdateCompanyPosition(CompanyPosition companyPosition);

        void DeleteCompanyPosition(int id);
    }
}

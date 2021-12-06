using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface ICountryServices
    {
        Task<IEnumerable<Country>> GetCountriesAsync();

        Country GetCountryByID(int id);

        void AddCountry(Country country);

        Country UpdateCountry(Country country);

        void DeleteCountry(int id);
    }
}

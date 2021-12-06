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

        Task<Country> GetCountryByIDAsync(int id);

        Task AddCountryAsync(Country country);

        Country UpdateCountry(Country countryToUpdate, Country country);

        void RemoveCountry(int id);
        void RemoveCountry(Country country);
    }
}

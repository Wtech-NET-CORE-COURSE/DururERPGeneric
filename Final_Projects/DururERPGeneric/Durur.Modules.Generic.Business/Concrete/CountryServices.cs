using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class CountryServices : ICountryServices
    {
        public Task AddCountryAsync(Country country)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Country>> GetCountriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetCountryByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCountry(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public Country UpdateCountry(Country countryToUpdate, Country country)
        {
            throw new NotImplementedException();
        }
    }
}

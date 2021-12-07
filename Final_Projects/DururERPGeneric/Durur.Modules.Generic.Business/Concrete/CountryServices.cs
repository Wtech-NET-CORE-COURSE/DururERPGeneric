using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class CountryServices : ICountryServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public CountryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddCountryAsync(Country country)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
            var countries = await _unitOfWork.Countries.GetAllAsync();
            return countries;
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

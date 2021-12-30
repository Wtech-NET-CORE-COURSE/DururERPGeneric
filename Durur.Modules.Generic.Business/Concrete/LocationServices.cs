using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class LocationServices : ILocationServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocationServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddLocationAsync(Location location)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Location>> GetByCountryID(int countryID)
        {
            return await _unitOfWork.Locations.GetLocationsByCountryID(countryID);
        }

        public Task<Location> GetLocationByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            return await _unitOfWork.Locations.GetAllAsync();
        }
        public async Task<IEnumerable<Location>> GetLocationsWithCountries()
        {
            return await _unitOfWork.Locations.GetLocationsWithCountries();
        }
        

        public Task RemoveLocation(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public Location UpdateLocation(Location locationToUpdate, Location location)
        {
            throw new NotImplementedException();
        }
    }
}

using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface ILocationServices
    {
        Task<IEnumerable<Location>> GetLocationsAsync();

        Task<Location> GetLocationByIDAsync(int id);

        Task AddLocationAsync(Location location);

        Location UpdateLocation(Location locationToUpdate,Location location);

        void RemoveLocation(int id);
        void RemoveLocation(Location location);
    }
}

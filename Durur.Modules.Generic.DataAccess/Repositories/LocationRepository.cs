using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(ErpGenericDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Location>> GetLocationsWithCountries()
        {
            //var locations = await Context.Locations.Join(Context.Countries,location=>location.Country.Country_ID,country=>country.Country_ID, (location,country)=> new Location {Location_ID= location.Location_ID,Country=country}).ToListAsync();
            var locations = await Context.Locations.Include(l=>l.Country).ToListAsync();
            //var locations = await Context.Locations.Select(l=>l);
            return locations;
        }

        public async Task<IEnumerable<Location>> GetLocationsByCountryID(int id)
        {            var locations = await Context.Locations.Where(l=>l.Country.Country_ID==id).ToListAsync();
            return locations;
        }
    }
}

using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(ErpGenericDbContext context) : base(context)
        {
        }
    }
}

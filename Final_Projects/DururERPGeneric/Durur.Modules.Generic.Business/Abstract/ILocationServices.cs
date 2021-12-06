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

        Location GetLocationByID(int id);

        void AddLocation(Location location);

        Location UpdateLocation(Location location);

        void DeleteLocation(int id);
    }
}

using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class SupplierRepository : Repository<Supplier>,ISupplierRepository
    {
        public SupplierRepository(ErpGenericDbContext context) : base(context)
        {
        }
    }
}

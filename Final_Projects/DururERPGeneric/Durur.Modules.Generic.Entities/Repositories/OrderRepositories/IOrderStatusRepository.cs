﻿using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Entities.Repositories
{
    public interface IOrderStatusRepository : IRepository<OrderStatus>
    {
        Task<IEnumerable<OrderStatus>> GetOrderStatusesAsync();
    }
}

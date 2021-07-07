using OnlineKrasotka.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Repository.Interfaces
{
    public interface IAllOrders
    {
        void CreateOrder(Order order);
    }
}

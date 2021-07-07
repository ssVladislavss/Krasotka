using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Entities.Order
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ThingsId { get; set; }
        public uint Price { get; set; }
        public virtual ThingItem Things { get; set; }
        public virtual Order Order { get; set; }
    }
}

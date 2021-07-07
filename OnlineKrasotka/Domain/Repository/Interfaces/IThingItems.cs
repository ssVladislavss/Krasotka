using OnlineKrasotka.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Repository.Interfaces
{
    public interface IThingItems
    {
        IQueryable<ThingItem> GetServiceItems();
        ThingItem GetServiceItemById(Guid id);
        void SaveServiceItem(ThingItem entity);
        void DeleteServiceItem(Guid id);
    }
}

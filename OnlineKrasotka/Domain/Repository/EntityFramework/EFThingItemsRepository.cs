using Microsoft.EntityFrameworkCore;
using OnlineKrasotka.Domain.Entities;
using OnlineKrasotka.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Repository.EntityFramework
{
    public class EFThingItemsRepository : IThingItems
    {
        private AppDb context;
        public EFThingItemsRepository(AppDb db) => context = db;
        public void DeleteServiceItem(Guid id)
        {
            var entity = context.ThingItems.FirstOrDefault(x => x.Id == id);
            context.ThingItems.Remove(entity);
            context.SaveChanges();            
        }

        public ThingItem GetServiceItemById(Guid id)
        {
            return context.ThingItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<ThingItem> GetServiceItems()
        {
            return context.ThingItems;
        }

        public void SaveServiceItem(ThingItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

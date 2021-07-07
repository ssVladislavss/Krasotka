using OnlineKrasotka.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain
{
    public class DataManager
    {
        public ITextFields TextFields { get; set; }
        public IThingItems ThingItems { get; set; }
        public DataManager(ITextFields text, IThingItems thing)
        {
            TextFields = text;
            ThingItems = thing;
        }
    }
}

using OnlineKrasotka.Domain.Entities.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.ViewModels
{
    public class AllThingsBasketViewModel
    {
        public Cart Basket { get; set; }
        public uint FullSumCart { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Entities.Cart
{
    public class ShopCartItem
    {
        public Guid Id { get; set; }//Это просто Id товара в корзине
        public ThingItem ThingCart { get; set; }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public uint PriceCart { get; set; }
        public string ThingsCartId { get; set; }//Это Id товара именно в корзине
    }
}

using OnlineKrasotka.Domain.Entities.Cart;
using OnlineKrasotka.Domain.Entities.Order;
using OnlineKrasotka.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Repository.EntityFramework
{
    public class OrderRepository:IAllOrders
    {
        private readonly AppDb content;
        private readonly Cart basket;
        public OrderRepository(AppDb content, Cart basket)
        {
            this.basket = basket;
            this.content = content;
        }
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            content.OrdersThings.Add(order);
            var items = basket.ListShopItems;
            foreach (var el in items)
            {
                var orderDetails = new OrderDetail()
                {
                    ThingsId = el.ThingCart.Id,
                    OrderId = order.Id,
                    Price = el.ThingCart.Price
                };
                content.OrderDetailsThings.Add(orderDetails);
            }
            //content.SaveChanges();
        }
    }
}

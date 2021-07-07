using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Entities.Cart
{
    public class Cart
    {
        private readonly AppDb data;
        public Cart(AppDb content) => this.data = content;
        public string ThingsCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }
        public static Cart GetCart(IServiceProvider services)//сначала пишем метод, который создаёт сессию
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;//Вот таким необычным образом мы создали новую сессию
            var SessionContext = services.GetService<AppDb>();//При помощи этой строки мы получаем различные таблички из базы данных
            string ShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();//В этой строке мы проверяем была ли у нас создана корзина ранее по Id корзины (CartId), если не было, то создаём новый Id
            session.SetString("CartId", ShopCartId);//В этой строке мы для корзины устанавливаем идентификатор полученный с предыдущей строки
            return new Cart(SessionContext) { ThingsCartId = ShopCartId };//мы возвращаем новый экземпляр корзины, в который будут помещаться товары с сайта.
        }
        public void AddToCart(ThingItem thingsModel)
        {
            ShopCartItem item = GetShopItems().FirstOrDefault(x => x.ThingCart.Id == thingsModel.Id);
            if (item == null)
            {
                data.CartItems.Add(new ShopCartItem
                {
                    ThingsCartId = ThingsCartId,
                    ThingCart = thingsModel,
                    PriceCart = thingsModel.Price,
                    Quantity = 1
                });
            }
            else
            {
                data.CartItems.RemoveRange(item);
                var SumPrice = thingsModel.Price * (item.Quantity + 1);
                data.CartItems.Add(new ShopCartItem
                {
                    ThingsCartId = ThingsCartId,
                    ThingCart = thingsModel,
                    PriceCart = thingsModel.Price * (uint)(item.Quantity + 1),
                    Quantity = item.Quantity + 1
                });
            }
            data.SaveChanges();
        }
        public void SubtractionToCart(ShopCartItem item)
        {
            var cartItem = data.CartItems.FirstOrDefault(x => x.Id == item.Id);
            if (cartItem.Quantity > 1)
            {
                data.CartItems.RemoveRange(cartItem);
                data.CartItems.Add(new ShopCartItem
                {
                    ThingsCartId = ThingsCartId,
                    ThingCart = data.ThingItems.FirstOrDefault(x => x.Id == cartItem.ThingCart.Id),
                    PriceCart = cartItem.ThingCart.Price * (uint)(cartItem.Quantity - 1),
                    Quantity = cartItem.Quantity - 1
                });
            }
            else
                data.CartItems.RemoveRange(item);
            data.SaveChanges();
        }
        public void AdditemToCart(ShopCartItem item)
        {
            var cartItem = data.CartItems.FirstOrDefault(x => x.Id == item.Id);
            data.CartItems.RemoveRange(cartItem);
            data.CartItems.Add(new ShopCartItem
            {
                ThingsCartId = ThingsCartId,
                ThingCart = data.ThingItems.FirstOrDefault(x => x.Id == cartItem.ThingCart.Id),
                PriceCart = cartItem.ThingCart.Price * (uint)(item.Quantity + 1),
                Quantity = cartItem.Quantity + 1
            });
            data.SaveChanges();
        }
        public uint FullSumCart()
        {
            var fullItems = GetShopItems();
            uint sumResult = 0;
            foreach (var item in fullItems)
            {
                sumResult += item.PriceCart;
            }
            return sumResult;
        }
        public void RemoveToCart(ShopCartItem item)
        {
            data.CartItems.RemoveRange(item);
            data.SaveChanges();
        }
        public void ClearToCart()
        {
            data.CartItems.RemoveRange(GetShopItems());
            data.SaveChanges();
        }
        public List<ShopCartItem> GetShopItems()// Этот метод позволяем получить все товары, которые находятся в корзине по Id сессии в виде List
        {
            return data.CartItems.Where(x => x.ThingsCartId == ThingsCartId).Include(x => x.ThingCart).ToList();
        }
    }
}

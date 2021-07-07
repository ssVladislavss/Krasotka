using Microsoft.AspNetCore.Mvc;
using OnlineKrasotka.Domain.Entities.Cart;
using OnlineKrasotka.Domain.Entities.Order;
using OnlineKrasotka.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders iAllOrder;
        private readonly Cart selection;
        public OrderController(IAllOrders app, Cart cart)
        {
            iAllOrder = app;
            selection = cart;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            selection.ListShopItems = selection.GetShopItems();
            if (selection.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У Вас должны быть товары");
            }
            if (ModelState.IsValid)
            {
                iAllOrder.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            selection.ClearToCart();
            return View();
        }
    }
}

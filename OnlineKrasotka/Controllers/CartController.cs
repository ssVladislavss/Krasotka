using Microsoft.AspNetCore.Mvc;
using OnlineKrasotka.Domain;
using OnlineKrasotka.Domain.Entities.Cart;
using OnlineKrasotka.Domain.Repository.Interfaces;
using OnlineKrasotka.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Controllers
{
    public class CartController : Controller
    {
        private readonly DataManager data;
        private readonly Cart _Cart;
        public CartController(DataManager data, Cart cart)
        {
            this.data = data;
            _Cart = cart;
        }
        public IActionResult Cart()
        {
            var ListBasketThings = _Cart.GetShopItems();
            _Cart.ListShopItems = ListBasketThings;
            var basketThingsViewModelResult = new AllThingsBasketViewModel
            {
                Basket = _Cart,
                FullSumCart = _Cart.FullSumCart()
            };
            return View(basketThingsViewModelResult);
        }
        public RedirectToActionResult addToBasket(Guid Id)
        {
            var AddToCartResult = data.ThingItems.GetServiceItemById(Id);
            if (AddToCartResult != null)
            {
                _Cart.AddToCart(AddToCartResult);
            }
            return RedirectToAction("Cart");
        }
        public RedirectToActionResult removeToCart(Guid Id)
        {
            var RemoveToCart = _Cart.GetShopItems();
            var RemoveToCartResult = RemoveToCart.FirstOrDefault(x => x.Id == Id);
            if (RemoveToCartResult != null)
            {
                _Cart.RemoveToCart(RemoveToCartResult);
            }
            return RedirectToAction("Cart");
        }
        public RedirectToActionResult subtractionToCart(Guid Id)
        {
            var subtraction = _Cart.GetShopItems();
            var subtractionResult = subtraction.FirstOrDefault(x => x.Id == Id);
            if (subtractionResult != null)
            {
                _Cart.SubtractionToCart(subtractionResult);
            }
            return RedirectToAction("Cart");
        }
        public RedirectToActionResult additemToCart(Guid Id)
        {
            var subtraction = _Cart.GetShopItems();
            var subtractionResult = subtraction.FirstOrDefault(x => x.Id == Id);
            if (subtractionResult != null)
            {
                _Cart.AdditemToCart(subtractionResult);
            }
            return RedirectToAction("Cart");
        }
    }
}

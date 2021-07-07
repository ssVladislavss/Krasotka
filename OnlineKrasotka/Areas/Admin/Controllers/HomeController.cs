using Microsoft.AspNetCore.Mvc;
using OnlineKrasotka.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager data;
        public HomeController(DataManager data) => this.data = data;
        public IActionResult Index()
        {
            return View(data.ThingItems.GetServiceItems());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using OnlineKrasotka.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager data;
        public ServicesController(DataManager manager) => data = manager;
        public IActionResult Index(Guid id)
        {
            if(id != default)
            {
                return View("Show", data.ThingItems.GetServiceItemById(id));
            }
            ViewBag.TextField = data.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(data.ThingItems.GetServiceItems());
        }
    }
}

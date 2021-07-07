using Microsoft.AspNetCore.Mvc;
using OnlineKrasotka.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager data;
        public HomeController(DataManager manager) => data = manager;
        public IActionResult Index()
        {
            return View(data.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }
        public IActionResult Contacts()
        {
            return View(data.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}

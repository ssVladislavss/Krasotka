using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineKrasotka.Domain;
using OnlineKrasotka.Domain.Entities;
using OnlineKrasotka.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThingItemsController : Controller
    {
        private readonly DataManager data;
        private readonly IWebHostEnvironment web;
        public ThingItemsController(DataManager data, IWebHostEnvironment web)
        {
            this.data = data;
            this.web = web;
        }
        
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ThingItem() : data.ThingItems.GetServiceItemById(id);
            return View(entity);
        }
        
        [HttpPost]
        public IActionResult Edit(ThingItem item, IFormFile titleImageFile)
        {
            if(ModelState.IsValid)
            {
                if(titleImageFile != null)
                {
                    item.TitleImagesPath = titleImageFile.FileName;
                    using(var stream = new FileStream(Path.Combine(web.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                data.ThingItems.SaveServiceItem(item);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(item);
        }
        
        //[HttpPost]
        public IActionResult Delete(Guid id)
        {
            data.ThingItems.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}

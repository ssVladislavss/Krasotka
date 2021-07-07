using Microsoft.AspNetCore.Mvc;
using OnlineKrasotka.Domain;
using OnlineKrasotka.Domain.Entities;
using OnlineKrasotka.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager data;
        private readonly AppDb db;
        public TextFieldsController(DataManager data, AppDb app) 
        {
            db = app;
            this.data = data;
        }
        public IActionResult Edit(string codeword)
        {
            var entity = data.TextFields.GetTextFieldByCodeWord(codeword);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(TextField text)
        {
            if(ModelState.IsValid)                
            {
                var entity = db.TextFields.FirstOrDefault(x => x.CodeWord == text.CodeWord);
                data.TextFields.DeleteTextField(entity.Id);                           
                data.TextFields.SaveTextField(text);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(text);
        }
    }
}

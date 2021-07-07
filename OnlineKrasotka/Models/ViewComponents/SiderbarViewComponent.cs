using Microsoft.AspNetCore.Mvc;
using OnlineKrasotka.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Models.ViewComponents
{
    public class SiderbarViewComponent:ViewComponent
    {
        private readonly DataManager data;
        public SiderbarViewComponent(DataManager data) => this.data = data;

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", data.ThingItems.GetServiceItems()));
        }
    }
}

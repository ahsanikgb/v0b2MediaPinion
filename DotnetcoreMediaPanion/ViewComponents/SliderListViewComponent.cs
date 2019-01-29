using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DotnetcoreMediaPanion.ViewModels1;
using Microsoft.AspNetCore.Mvc;

namespace MediaPanionCore.ViewComponents
{
    public class SliderListViewComponent : ViewComponent
    {
      
        private readonly MyFirstDBContext db;
        public SliderListViewComponent(MyFirstDBContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private async Task<IEnumerable<Slider>> GetItemsAsync()
        {
            
            var Details = from d in db.Slider select d;
            return Details;

        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetcoreMediaPanion.ViewModels1;
using Microsoft.AspNetCore.Mvc;

namespace MediaPanionCore.ViewComponents
{
    public class ServicesListViewComponent : ViewComponent
    {
      
        private readonly MyFirstDBContext db;
        public ServicesListViewComponent(MyFirstDBContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private async Task<IEnumerable<Services>> GetItemsAsync()
        {
            
            var Details = from d in db.Services select d;
            return Details;
        }
    }
}

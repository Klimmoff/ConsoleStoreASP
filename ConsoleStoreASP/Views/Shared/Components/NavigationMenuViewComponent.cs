using ConsoleStoreASP.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ConsoleStoreASP.Views.Shared.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        ConsoleContext db;
        public NavigationMenuViewComponent(ConsoleContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(db.CategoryTable.OrderBy(c => c.categoryName));
        }
    }
}

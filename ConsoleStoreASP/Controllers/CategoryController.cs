using ConsoleStoreASP.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ConsoleStoreASP.Controllers
{
    public class CategoryController : Controller
    {
        private ConsoleContext db;

        public CategoryController(ConsoleContext context) 
        {
            db= context;
        }
        public IActionResult StationCategory()
        {
            ViewBag.Title = "Список стационарных категорий";
            return View(db.CategoryTable.First());
        }
        public IActionResult PortCategory()
        {
            ViewBag.Title = "Список портативных категорий";
            return View(db.CategoryTable.ToList().Last());
        }
        //public IActionResult Index()
        //{
        //    ViewBag.Title = "Список категорий";
        //    return View(db.CategoryTable);
        //}
    }
}

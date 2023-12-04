using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ConsoleStoreASP.Data.Context;
using ConsoleStoreASP.Data.Models;
using ConsoleStoreASP.Data.Repository;
using ConsoleStoreASP.Data.ViewModels;
using ConsoleStoreASP.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConsoleStoreASP.Controllers
{
    public class HomeController : Controller
    {
        ConsoleContext db;
        private int pageSize = 0;
        private int MaxPage => (int)Math.Ceiling((decimal)db.ConsoleTable.Count() / pageSize);
        public HomeController(ConsoleContext context)
        {
            db = context;
        }

        public IActionResult Main(int category = 1, int page = 1)
        {
            PageLinkTagHelper.categoryId = category;
            ViewBag.Title = "Главная страница";
            return View(
                new ConsolesPagingModel
                {
                    Consoles = db.ConsoleTable
                    .Where(c => c.CategoryId == category)
                    .OrderBy(c => c.id)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = pageSize,
                        TotalItems = db.ConsoleTable.Where(c => c.CategoryId == category).Count()
                    },
                    CurrentCategory = category
                });
        }

        public IActionResult AddAllConsole()
        {
            ArrConsoles arrConsoles = new ArrConsoles();
            foreach (Consoles cons in arrConsoles.Consoles)
            {
                db.ConsoleTable.Add(cons);
            }
            db.SaveChanges();
            return RedirectToAction("Main");
        }



        //public void Notfication(string accountIsAccessed)
        //{
        //    if(db.ConsoleTable.ToList().Count > 0)
        //    {
        //        accountIsAccessed = "Access";
        //    }
        //    else
        //    {
                
        //    }
        //}
    }
}
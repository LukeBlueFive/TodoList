using TodoList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }

        [HttpGet("/items/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                Item myItem = new(text);
            }

            return RedirectToAction("Index");
        }

        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
            Item.ClearAll();
            return RedirectToAction("Index");
        }
    }
}
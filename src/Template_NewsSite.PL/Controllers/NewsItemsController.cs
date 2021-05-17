using Microsoft.AspNetCore.Mvc;
using System;
using Template_NewsSite.PL.Domain.Managers;

namespace Template_NewsSite.PL.Controllers
{
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;

        public NewsItemsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Shaw", dataManager.NewsItems.GetNewsItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageNews");

            return View(dataManager.NewsItems.GetNewsItem());
        }
    }
}

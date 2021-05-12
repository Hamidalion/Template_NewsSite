using Microsoft.AspNetCore.Mvc;
using Template_NewsSite.PL.Domain.Managers;

namespace Template_NewsSite.PL.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.NewsItems.GetNewsItem());
        }
    }
}

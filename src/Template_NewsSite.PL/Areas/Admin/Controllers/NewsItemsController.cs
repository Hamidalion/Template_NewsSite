using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Template_NewsSite.PL.Domain.Entities;
using Template_NewsSite.PL.Domain.Managers;
using Template_NewsSite.PL.Extensions;

namespace Template_NewsSite.PL.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnviroment; // Hosting enviroment for saving title pictures.

        public NewsItemsController(DataManager dataManager, IWebHostEnvironment hostEnviroment)
        {
            this.dataManager = dataManager;
            this.hostEnviroment = hostEnviroment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new NewsItem() : dataManager.NewsItems.GetNewsItemById(id); // if id == default create, else get from db
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(NewsItem model, IFormFile titleImgFile) // interface to sending picture by http
        {
            //TODO: check input parametrs
            if (ModelState.IsValid)
            {
                if (titleImgFile != null)
                {
                    model.TitleImagePath = titleImgFile.FileName;
                }

                using (var stream = new FileStream(Path.Combine(hostEnviroment.WebRootPath, "images/", titleImgFile.FileName), FileMode.Create))
                {
                    titleImgFile.CopyTo(stream);
                }
                dataManager.NewsItems.SaveNewsItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.NewsItems.DeleteNewsItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Template_NewsSite.PL.Domain.Managers;

namespace Template_NewsSite.PL.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent  // base on Microsoft.AspNetCore.Mvc;
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("default", dataManager.NewsItems.GetNewsItem()));
        }
    }
}

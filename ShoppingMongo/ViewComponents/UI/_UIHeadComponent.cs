using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UIHeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
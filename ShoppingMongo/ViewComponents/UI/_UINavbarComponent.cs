using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UINavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
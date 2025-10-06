using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UIScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Services.CategoryServices;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UICategoryComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _UICategoryComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
    }
}
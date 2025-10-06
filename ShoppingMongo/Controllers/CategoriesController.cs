using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using ShoppingMongo.DTOS.CategoryDtos;
using ShoppingMongo.DTOS.ProductDtos;
using ShoppingMongo.Entities;
using ShoppingMongo.Models;
using ShoppingMongo.Services.CategoryServices;
using ShoppingMongo.Services.ProductServices;

namespace ShoppingMongo.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IProductService productService, IMapper mapper)
        {
            _categoryService = categoryService;
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            var products = await _productService.GetAllProductAsync();
            var model = new AdminPanelViewModel
            {
                Categories = _mapper.Map<List<ResultCategoryDto>>(categories),
                Products = _mapper.Map<List<GetProductByIdDto>>(products)
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto dto)
        {
            await _categoryService.CreateCategoryAsync(dto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);            
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryDto dto)
        {
            await _categoryService.UpdateCategoryAsync(dto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction("Index");
        }

    }
}
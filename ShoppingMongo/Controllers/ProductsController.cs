using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.DTOS.CategoryDtos;
using ShoppingMongo.DTOS.ProductDtos;
using ShoppingMongo.Entities;
using ShoppingMongo.Services.CategoryServices;
using ShoppingMongo.Services.ProductServices;

namespace ShoppingMongo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productService.GetAllProductAsync();
            return View(_mapper.Map<List<ResultProductDto>>(values));
        }

        [HttpGet]
        public async Task< IActionResult> CreateProduct()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            createProductDto.Status = true;
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.Categories = categories;

            var value = await _productService.GetProductByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("Index");
        }
    }
}

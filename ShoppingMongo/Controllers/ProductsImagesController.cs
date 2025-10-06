using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingMongo.DTOS.ProductDtos;
using ShoppingMongo.DTOS.ProductImageDtos;
using ShoppingMongo.Services.ProductImageServices;
using ShoppingMongo.Services.ProductServices;

namespace ShoppingMongo.Controllers
{
    public class ProductsImagesController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductImageService _imageService;
        private readonly IMapper _mapper;

        public ProductsImagesController(IProductService productService, IProductImageService imageService, IMapper mapper)
        {
            _productService = productService;
            _imageService = imageService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _imageService.GetAllProductImageAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProductImage()
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.v = products.Select(c => new SelectListItem
            {
                Text = c.ProductName,
                Value = c.ProductId
            }).ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _imageService.CreateProductImageAsync(createProductImageDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _imageService.DeleteProductImageAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProductImage(string id)
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.v = products.Select(c => new SelectListItem
            {
                Text = c.ProductName,
                Value = c.ProductId
            }).ToList();

            var ProductImage = await _imageService.GetProductImageByIdAsync(id);
            return View(ProductImage);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _imageService.UpdateProductImageAsync(updateProductImageDto);
            return RedirectToAction("Index");
        }

    }
}

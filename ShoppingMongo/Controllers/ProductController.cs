using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.DTOS.ProductDtos;
using ShoppingMongo.Services.ProductServices;

namespace ShoppingMongo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(string categoryId = null)
        {
            if (string.IsNullOrEmpty(categoryId))
            {
                var allProducts = await _productService.GetAllProductsAsync();
                var dtoList = _mapper.Map<List<GetProductDto>>(allProducts);
                return View(dtoList);
            }
            else
            {
                var filtered = await _productService.GetProductsByCategoryAsync(categoryId);
                var dtoList = _mapper.Map<List<GetProductDto>>(filtered);
                return View(dtoList);
            }
        }

    }
}

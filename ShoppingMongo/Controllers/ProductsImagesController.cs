using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.DTOS.ProductDtos;
using ShoppingMongo.DTOS.ProductImageDtos;
using ShoppingMongo.Services.ProductImageServices;

namespace ShoppingMongo.Controllers
{
    public class ProductsImagesController : Controller
    {
        private readonly IProductImageService _imageService;
        private readonly IMapper _mapper;

        public ProductsImagesController(IProductImageService imageService, IMapper mapper)
        {
            _imageService = imageService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _imageService.GetProductImageByIdAsync();
            return View(values);
        }
    }
}

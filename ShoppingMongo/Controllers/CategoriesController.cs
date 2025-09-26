using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using ShoppingMongo.DTOS.CategoryDtos;
using ShoppingMongo.Entities;
using ShoppingMongo.Services.CategoryServices;

namespace ShoppingMongo.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            var values = _mapper.Map<List<GetCategoryDto>>(categories);
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto dto)
        {
            var category = _mapper.Map<Category>(dto);
            await _categoryService.CreateAsync(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var values = _mapper.Map<UpdateCategoryDto>(category);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryDto dto)
        {
            var category = _mapper.Map<Category>(dto);
            await _categoryService.UpdateAsync(category);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _categoryService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
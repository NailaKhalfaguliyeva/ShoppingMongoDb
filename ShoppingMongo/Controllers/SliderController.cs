using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.DTOS.SliderDtos;
using ShoppingMongo.Services.SliderServices;

namespace ShoppingMongo.Controllers
{
    public class SliderController : Controller
    {
       public readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            await _sliderService.CreateSliderAsync(createSliderDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteSlider(string id)
        {
            await _sliderService.DeleteSliderAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSlider(string id)
        {
            var Slider = await _sliderService.GetSliderByIdAsync(id);
            return View(Slider);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            await _sliderService.UpdateSliderAsync(updateSliderDto);
            return RedirectToAction("Index");
        }
    }
}
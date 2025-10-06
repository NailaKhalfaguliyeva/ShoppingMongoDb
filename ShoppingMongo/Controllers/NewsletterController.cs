using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.DTOS.NewsletterDtos;
using ShoppingMongo.Entities;
using ShoppingMongo.Services.NewsletterServices;

namespace ShoppingMongo.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterservice)
        {
            _newsletterService = newsletterservice;
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(CreateNewsletterDto dto)
        {
            if (string.IsNullOrEmpty(dto.Email))
                return BadRequest("Email cannot be blank.");

            await _newsletterService.CreateNewsletterAsync(dto);

            await _newsletterService.SendNewsletterMailAsync(dto.Email);

            return RedirectToAction("Subscription successful! Email sent.");
        }

    }
}

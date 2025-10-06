using ShoppingMongo.DTOS.NewsletterDtos;

namespace ShoppingMongo.Services.NewsletterServices
{
    public interface INewsletterService
    {
        Task CreateNewsletterAsync(CreateNewsletterDto newsletter);
        Task SendNewsletterMailAsync(string email);
    }
}

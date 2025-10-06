using MailKit.Net.Smtp;
using MimeKit;
using MongoDB.Driver;
using ShoppingMongo.DTOS.NewsletterDtos;
using ShoppingMongo.Entities;


namespace ShoppingMongo.Services.NewsletterServices
{
    public class NewsletterService : INewsletterService
    {
        private readonly IMongoCollection<Newsletter> _collection;

        public NewsletterService(IMongoDatabase database)
        {
            _collection = database.GetCollection<Newsletter>("Newsletters");
        }

        public async Task CreateNewsletterAsync(CreateNewsletterDto dto)
        {
            var newsletter = new Newsletter { Email = dto.Email };
            await _collection.InsertOneAsync(newsletter);
        }

        public async Task SendNewsletterMailAsync(string email)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Cozastore", "naila@gmail.com"));
            message.To.Add(new MailboxAddress("", email));
            message.Subject = "🎉Your 20% Discount Coupon is Ready!";
            message.Body = new TextPart("plain")
            {
                Text = "Hello, a 20% discount coupon has been added to your account. Your coupon code is: 254585"
            };

            using var client = new SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            await client.AuthenticateAsync("naila@gmail.com", "App-password");
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }
    }
}

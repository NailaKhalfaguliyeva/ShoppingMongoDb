namespace ShoppingMongo.DTOS.NewsletterDtos
{
    public class CreateNewsletterDto
    {
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}

namespace ShoppingMongo.DTOS.ProductDtos
{
    public class UpdateProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public string ImageUrl { get; set; }
    }
}

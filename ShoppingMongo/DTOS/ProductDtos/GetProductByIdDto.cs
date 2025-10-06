namespace ShoppingMongo.DTOS.ProductDtos
{
    public class GetProductByIdDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductDescription { get; set; }
        public string Gender { get; set; }
        public int StockCount { get; set; }
        public bool Status { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
    }
}

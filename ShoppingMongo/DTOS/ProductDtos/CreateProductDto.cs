using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ShoppingMongo.DTOS.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }        
        public string CategoryId { get; set; }
        public string ProductDescription { get; set; }
        public string Gender { get; set; }
        public int StockCount { get; set; }
        public bool Status { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ShoppingMongo.DTOS.ProductImageDtos
{
    public class ResultProductImageDto
    {        
        public string ProductImageId { get; set; }
                
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string ImageUrl { get; set; }
    }
}

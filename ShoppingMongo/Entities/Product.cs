using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ShoppingMongo.Entities
{
    
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }

        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }        
        public string ProductDescription { get; set; }
        public string Gender { get; set; }
        public int StockCount { get; set; }
        public bool Status { get; set; }
    }
}

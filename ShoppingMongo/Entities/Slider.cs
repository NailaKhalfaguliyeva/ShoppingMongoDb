using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingMongo.Entities
{
    public class Slider
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string SliderId { get; set; }
        public string SliderTitle { get; set; }
        public string SliderSubtitle { get; set; }
        public string SliderImageUrl { get; set; }
    }
}

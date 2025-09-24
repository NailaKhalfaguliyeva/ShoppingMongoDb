using AutoMapper;
using MongoDB.Driver;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Services.ProductServices
{
    public class ProductService: IProductService
    {
        
        private readonly IMongoCollection<Product> _productCollection;

        public ProductService(IMongoDatabase database)
        {
            _productCollection = database.GetCollection<Product>("Products");
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string categoryId)
        {
            return await _productCollection.Find(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}

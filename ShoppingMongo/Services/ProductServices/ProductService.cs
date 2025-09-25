using AutoMapper;
using MongoDB.Driver;
using ShoppingMongo.Entities;
using ShoppingMongo.Settings;

namespace ShoppingMongo.Services.ProductServices
{
    public class ProductService: IProductService
    {
        
        private readonly IMongoCollection<Product> _productCollection;

        public ProductService(IDatabaseSettings databaseSettings, IMongoDatabase database)
        {
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollectionName);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productCollection.Find(x => true).ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string categoryId)
        {
            return await _productCollection.Find(x => x.CategoryId == categoryId).ToListAsync();
        }
    }
}

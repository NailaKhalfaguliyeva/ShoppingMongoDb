using ShoppingMongo.Entities;

namespace ShoppingMongo.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsByCategoryAsync(string categoryId);
    }
}

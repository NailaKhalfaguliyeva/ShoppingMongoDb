using ShoppingMongo.DTOS.ProductImageDtos;

namespace ShoppingMongo.Services.ProductImageServices
{
    public interface IProductImageService
    {
        
        
        Task<string?> GetProductImageByIdAsync();
    }
}

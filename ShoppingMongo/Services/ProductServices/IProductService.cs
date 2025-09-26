using ShoppingMongo.DTOS.ProductDtos;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetProductByIdDto> GetProductByIdAsync(string id);
    }
}

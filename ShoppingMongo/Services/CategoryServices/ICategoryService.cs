using ShoppingMongo.Entities;

namespace ShoppingMongo.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync();
        Task<Category> GetByIdAsync(string id);
        Task CreateAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(string id);
    }
}

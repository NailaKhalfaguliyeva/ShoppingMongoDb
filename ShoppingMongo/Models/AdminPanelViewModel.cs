using ShoppingMongo.DTOS.CategoryDtos;
using ShoppingMongo.DTOS.ProductDtos;

namespace ShoppingMongo.Models
{
    public class AdminPanelViewModel
    {
        public List<ResultCategoryDto> Categories { get; set; }

        public List<GetProductByIdDto> Products { get; set; }
    }
}

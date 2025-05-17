using Services.Dtos;

namespace Services.IServices
{
    public interface IService
    {
        Task AddCategory(CategoryModel model);
        Task<List<CategoryModel>> GetAllCategories();
    }
}

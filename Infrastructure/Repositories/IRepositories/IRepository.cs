using Domain;

namespace Infrastructure.Repositories.IRepositories
{
    public interface IRepository
    {
        Task AddCategory(string categoryName);
        Task<List<Category>> GetAllCategories();

        //Task AddMilk(Milk milk);
        //Task<List<Milk>> GetAllMilks();
    }
}

using Services.Dtos;

namespace Services.IServices
{
    public interface IService
    {
        Task AddCategory(CategoryModel model);
        Task<List<CategoryModel>> GetAllCategories();

        Task AddExpense(ExpenseModel model);
        Task<List<ExpenseModel>> GetAllExpenses();
    }
}
using AutoMapper;
using Domain;
using Infrastructure.Repositories.IRepositories;
using Services.Dtos;
using Services.IServices;

namespace Services.Services
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }

        public async Task AddCategory(CategoryModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");

            var newCategory = new Category
            {
                Name = model.Name,
                IsActive = model.IsActive
            };

            await _repository.AddCategory(newCategory.Name); // Ya maneja IsActive en el constructor
        }

        public async Task AddExpense(ExpenseModel model)
        {
            var expense = new Expense
            {
                Date = model.Date,
                Category = model.Category,
                Name = model.Name,
                Cost = model.Cost,
                Power = model.Power
            };

            await _repository.AddExpense(expense);
        }

        public async Task<List<ExpenseModel>> GetAllExpenses()
        {
            var expenses = await _repository.GetAllExpenses();
            return expenses.Select(e => new ExpenseModel
            {
                Date = e.Date,
                Category = e.Category,
                Name = e.Name,
                Cost = e.Cost,
                Power = e.Power
            }).ToList();
        }

        public async Task<List<CategoryModel>> GetAllCategories()
        {
            var categories = await _repository.GetAllCategories();
            return categories.Select(c => new CategoryModel
            {
                Name = c.Name,
                IsActive = c.IsActive
            }).ToList();
        }
    }
}
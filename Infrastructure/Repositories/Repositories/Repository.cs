using Domain;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Repositories
{
    public class Repository : BaseRepository, IRepository
    {
        public Repository(ApplicationDbContext _context) : base(_context)
        {
        }

        public async Task AddCategory(string categoryName)
        {
            Category NewCategory = new Category(categoryName);
            try
            {
                Begin();
                context.Categories.Add(NewCategory);
                await context.SaveChangesAsync();
                Commit();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while adding new category", ex);
            }
        }

        public async Task<List<Category>> GetAllCategories()
        {
            try
            {
                return await context.Categories.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving categories", ex);
            }
        }

        //public async Task AddMilk(Milk milk)
        //{
        //    try
        //    {
        //        Begin();
        //        context.Milks.Add(milk);
        //        await context.SaveChangesAsync();
        //        Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error while adding milk", ex);
        //    }
        //}

        //public Task<List<Milk>> GetAllMilks()
        //{
        //    return context.Milks.ToListAsync();
        //}
    }
}
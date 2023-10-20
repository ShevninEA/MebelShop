using MebelShop.Data;
using MebelShop.Model;

namespace MebelShop.Services.Impl
{
    /// <summary>
    /// Репозиторий категории
    /// </summary>
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MebelShopDbContext _dbContext;

        public CategoryRepository(MebelShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(Category data)
        {
            _dbContext.Category.Add(data);
            _dbContext.SaveChanges();
            return data.Id;
        }

        public bool Delete(int id)
        {
            Category category = GetById(id);
            if (category != null)
            {
                _dbContext.Category.Remove(category);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<Category> GetAll()
        {
            return _dbContext.Category.ToList();
        }

        public Category GetById(int id)
        {
            return _dbContext.Category.FirstOrDefault(et => et.Id == id);
        }

        public bool Update(Category data)
        {
            Category category = GetById(data.Id);
            if (category != null)
            {
                _dbContext.Category.Update(category);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

using MebelShop.Data;
using MebelShop.Model;

namespace MebelShop.Services.Impl
{
    /// <summary>
    /// Репозиторий товара
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private readonly MebelShopDbContext _dbContext;

        public ProductRepository(MebelShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(Product data)
        {
            _dbContext.Product.Add(data);
            _dbContext.SaveChanges();
            return data.Id;
        }

        public bool Delete(int id)
        {
            Product product = GetById(id);
            if (product != null)
            {
                _dbContext.Product.Remove(product);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<Product> GetAll()
        {
            return _dbContext.Product.ToList();
        }

        public Product GetById(int id)
        {
            return _dbContext.Product.FirstOrDefault(et => et.Id == id);
        }

        public bool Update(Product data)
        {
            Product product = GetById(data.Id);
            if (product != null)
            {
                _dbContext.Product.Update(product);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

using MebelShop.Data;
using MebelShop.Model;
using Microsoft.EntityFrameworkCore;

namespace MebelShop.Services.Impl
{
    /// <summary>
    /// Репозиторий каталога
    /// </summary>
    public class CatalogRepository : ICatalogRepository
    {
        private readonly MebelShopDbContext _dbContext;

        public CatalogRepository(MebelShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(Catalog data)
        {
            _dbContext.Catalog.Add(data);
            _dbContext.SaveChanges();
            return data.Id;
        }

        public bool Delete(int id)
        {
            Catalog catalog = GetById(id);
            if (catalog != null)
            {
                _dbContext.Catalog.Remove(catalog);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<Catalog> GetAll()
        {
            return _dbContext.Catalog.ToList();
        }

        public Catalog GetById(int id)
        {
            return _dbContext.Catalog.FirstOrDefault(et => et.Id == id);
        }

        public bool Update(Catalog data)
        {
            Catalog catalog = GetById(data.Id);
            if (catalog != null)
            {
                _dbContext.Catalog.Update(catalog);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

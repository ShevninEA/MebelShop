using MebelShop.Data;
using MebelShop.Model;

namespace MebelShop.Services
{
    /// <summary>
    /// Интерфейс товара
    /// </summary>
    public interface IProductRepository : IRepository<Product, int> { }
}

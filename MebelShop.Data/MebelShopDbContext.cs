using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelShop.Data
{
    public class MebelShopDbContext : DbContext
    {
        public DbSet<Catalog> Catalog { get; set; } // Создаем таблицу Catalog
        public DbSet<Category> Category { get; set; } // Создаем таблицу Category
        public DbSet<Product> Product { get; set; } // Создаем таблицу Product

        #region Ctor

        public MebelShopDbContext(DbContextOptions options) : base(options)
        {
             
        }

        #endregion
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelShop.Data
{
    /// <summary>
    /// Отдельная сборка для работы с СУБД (для универсальности)
    /// </summary>
    public class MebelShopDbContext : DbContext
    {
        #region Ctor

        public MebelShopDbContext(DbContextOptions options) : base(options)
        {
             
        }

        #endregion
    }
}

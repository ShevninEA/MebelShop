using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelShop.Data
{
    [Table ("Catalog")]
    public class Catalog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column]
        [StringLength(128)]
        public string CatalogName { get; set; }

        [InverseProperty(nameof(Category.Catalog))]
        public virtual ICollection<Category> Categorys { get; set; } = new HashSet<Category>();
    }
}

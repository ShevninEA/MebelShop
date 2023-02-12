using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelShop.Data
{
    [Table("Product")]
    public class Product
    {
        [BindNever]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [Column]
        [StringLength(128)]
        public string ProductName { get; set; }

        [Column]
        [StringLength(128)]
        public string ShortDesc { get; set; }

        [Column]
        [StringLength(510)]
        public string LongDesc { get; set; }

        [Column]
        [StringLength(255)]
        public string Img { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column]
        public bool IsFavorite { get; set; }

        [Column]
        public bool Available { get; set; }

        public Category Category { get; set; }
    }
}

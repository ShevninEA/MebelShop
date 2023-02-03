namespace MebelShop.Model
{
    /// <summary>
    /// Модель объекта товара
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; } // Краткое описание
        public string LongDesc { get; set; } // Длинное описание
        public string Img { set; get; } // URL картинки товара
        public ushort Price { set; get; } // Цена товара
        public bool IsFavorite { set; get; } // Товар на главной странице сайта
        public int CatalogId { get; set; } // Id основного каталога
        public int CategoryId { get; set; } // Id категории каталога
    }
}

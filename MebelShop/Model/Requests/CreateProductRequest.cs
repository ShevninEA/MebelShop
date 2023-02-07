namespace MebelShop.Model.Requests
{
    /// <summary>
    /// Вспомогательный класс создания объекта товара
    /// </summary>
    public class CreateProductRequest
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ShortDesc { get; set; } // Краткое описание
        public string LongDesc { get; set; } // Длинное описание
        public string Img { set; get; } // URL картинки товара
        public decimal Price { set; get; } // Цена товара
        public bool IsFavorite { set; get; } // Товар на главной странице сайта
        public bool Available { set; get; } // Наличие товара
        public int CategoryId { get; set; } // Id категории каталога
    }
}

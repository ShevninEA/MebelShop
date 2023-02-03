namespace MebelShop.Model
{
    /// <summary>
    /// Модель объекта категории (кухонны стол, журнальный стол и.т.д)
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CatalogId { get; set; } // Id каталога в котором находится категория
    }
}

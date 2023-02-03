namespace MebelShop.Model.Requests
{
    /// <summary>
    /// Вспомогательный класс создания объекта категории
    /// </summary>
    public class CreateCategoryRequest
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CatalogId { get; set; } // Id каталога в котором находится категория
    }
}

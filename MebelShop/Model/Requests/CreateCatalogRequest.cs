namespace MebelShop.Model.Requests
{
    /// <summary>
    /// Вспомогательный класс создания объекта каталога
    /// </summary>
    public class CreateCatalogRequest
    {
        public int Id { get; set; }
        public string CatalogName { get; set; }
    }
}

namespace MebelShop.Services
{/// <summary>
/// Обобщенный базовй интерфейс
/// </summary>
/// <typeparam name="T"></typeparam>
    public interface IRepository<T, TId>
    {
        IList<T> GetAll(); // Получить полный список объектов
        T GetById(TId id); // Получить объект по Id
        int Create(T data); // Создание объекта
        void Update(T data); // Изменить объект
        void Delete(TId id); // Удаление объект
    }
}

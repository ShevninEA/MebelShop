namespace MebelShop.Services
{/// <summary>
/// Обобщенный базовй интерфейс
/// </summary>
/// <typeparam name="T"></typeparam>
    public interface IRepository<T, TId>
    {
        IList<T> GetAll(); // Получить полный список объектов
        T GetById(TId id); // Получить объект по Id
        int Create(T data); // Создать объекта
        bool Update(T data); // Изменить объект
        bool Delete(TId id); // Удалить объект
    }
}

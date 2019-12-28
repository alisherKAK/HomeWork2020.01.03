namespace HomeWork2020._03._01.AbstractModels
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Delete(T item);
        string GetAll();
    }
}

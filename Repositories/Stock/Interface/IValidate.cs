namespace Repositories.Stock.Interface
{
    public interface IValidate<T>
    {
        bool Create(T obj);
        bool Update(T obj);
        bool Delete(int id);
        bool Get(int id);
        bool GetForCode(long code);
    }
}

namespace Repositories.Stock.Interface
{
    public  interface IRepository<T>
    {
        T Add(T obj);
        T Update(T obj);
        T Delete(int id);
        T Get(int id);
    }
}

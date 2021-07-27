namespace GlobalServices.Interface
{
    public interface IGlobalServices<T>
    {
        T Create(T obj);
        int Add(T obj);
        T Update(T obj);
        void Delete(int id);
        int Remove(int id);
    }
}

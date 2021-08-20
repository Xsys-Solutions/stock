using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Stock.Interface
{
    public  interface IRepository<T>
    {
        Task<T> CreateAsync(T obj);
        Task<T> UpdateAsync(T obj);
        Task<T> DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
        Task<T> GetByCodeAsync(long code);
        Task<ICollection<T>> GetAllAsync();
    }
}

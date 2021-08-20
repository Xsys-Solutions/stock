using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Stock.Interface
{
    public interface IRepositoryService<TRequest,TResponse>
    {
        Task<TResponse> CreateAsync(TRequest obj);
        Task<TResponse> UpdateAsync(TRequest obj);
        Task<string> DeleteAsync(int id);
        Task<TResponse> GetByIdAsync(int id);
        Task<IEnumerable<TResponse>> GetAllAsync();
    }
}

using DTO.Model.Products;
using Repositories.Stock.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GlobalServices.Interface
{
    public interface IGlobalServices<TRequest, TResponse>
    {
        Task<TResponse> CreateAsync(TRequest obj);
        Task<ICollection<TResponse>> GetAllAsync();
        Task<string> DeleteAsync(int id);
        Task<TResponse> UpdateAsync(TRequest obj);
    }
}
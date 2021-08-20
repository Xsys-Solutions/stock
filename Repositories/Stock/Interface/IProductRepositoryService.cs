using DTO.Model.Products;
using System.Threading.Tasks;

namespace Repositories.Stock.Interface
{
    public interface IProductRepositoryService : IRepositoryService<ProductRequest, ProductResponse>
    {
    }
}

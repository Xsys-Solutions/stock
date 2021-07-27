using Entities.Stock;

namespace GlobalServices.Interface
{
    public interface IProductGlobalServices : IGlobalServices<Product>
    {
        int CheckAmount(int id);
    }
}

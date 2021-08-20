using DTO.Model.Products;

namespace GlobalServices.Interface
{
    public interface IProductServices : IGlobalServices<ProductRequest, ProductResponse>
    {
    }
}

using GlobalServices.CommandHandler.Stock.Commands.Request;
using GlobalServices.CommandHandler.Stock.Commands.Response;
using System.Collections.Generic;

namespace GlobalServices.CommandHandler.Stock.Interfaces
{
    public interface IProductHandlers
    {
        ProductCreateResponse Handler(ProductCreateRequest obj);
        ProductDeleteResponse Handler(ProductDeleteRequest obj);
        ProductEditResponse Handler(ProductEditRequest obj);
        ICollection<ProductFindResponse> Handler(ProductFindRequest obj);
        ICollection<ProductFindResponse> Handler();
        ProductFindResponse Handler(int ProductId);
    }
}

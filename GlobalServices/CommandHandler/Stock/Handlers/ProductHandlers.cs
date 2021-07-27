using GlobalServices.CommandHandler.Stock.Commands.Request;
using GlobalServices.CommandHandler.Stock.Commands.Response;
using GlobalServices.CommandHandler.Stock.Interfaces;
using Repositories.Stock.Interface;
using System.Collections.Generic;

namespace GlobalServices.GlobalServices.CommandHandler.Stock.Handlers
{
    public class ProductHandlers : IProductHandlers
    {
        private readonly IProductRepositoryService _service;

        public ProductHandlers(IProductRepositoryService service)
        {
            _service = service;
        }
        public ProductCreateResponse Handler(ProductCreateRequest obj)
        {

            _service.Add();
            throw new System.NotImplementedException();
        }

        public ProductDeleteResponse Handler(ProductDeleteRequest obj)
        {
            throw new System.NotImplementedException();
        }

        public ProductEditResponse Handler(ProductEditRequest obj)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<ProductFindResponse> Handler(ProductFindRequest obj)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<ProductFindResponse> Handler()
        {
            throw new System.NotImplementedException();
        }

        public ProductFindResponse Handler(int ProductId)
        {
            throw new System.NotImplementedException();
        }
    }
}

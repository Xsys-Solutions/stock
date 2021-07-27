using Entities.Stock;
using GlobalServices.Interface;
using Repositories.Stock.Interface;

namespace GlobalServices.GlobalServices
{
    public class ProductGlobalServices : IProductGlobalServices
    {
        private readonly IProductRepositoryService _service;

        public ProductGlobalServices(IProductRepositoryService service)
        {
            _service = service;
        }
        public Product Create(Product obj)
        {
            throw new System.NotImplementedException();
        }
        public Product Update(Product obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
        public int Add(Product obj)
        {
            throw new System.NotImplementedException();
        }
        public int Remove(int id)
        {
            _service.Remove(id);
            return _service.Get(id).Amount;
        }

        public int CheckAmount(int id)
        {
            return _service.Get(id).Amount;
        }
    }
}

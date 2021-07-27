using Entities.Stock;
using Repositories.Stock.Interface;

namespace Repositories.Stock.Service
{
    public class ProductService : IProductRepositoryService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public int Remove(int id)
        {
            var product = _productRepository.Get(id);
            product.Amount--;
            _productRepository.Update(product);
            return _productRepository.Get(id).Amount;
        }

        public Product Create(Product obj)
        {
            Validation(obj);
            _productRepository.Add(obj);
            return obj;
        }

        public Product Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product Update(Product obj)
        {
            throw new System.NotImplementedException();
        }

        public string[] Validation(Product obj)
        {
            return null;// new string[]{ ""};
        }

        public int Add(Product obj)
        {
            throw new System.NotImplementedException();
        }
    }
}

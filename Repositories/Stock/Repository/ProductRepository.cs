using EF.Data;
using Entities.Stock;
using Repositories.Stock.Interface;

namespace Repositories.Stock.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly StockContext _context;

        public ProductRepository(StockContext context)
        {
            _context = context;
        }

        public Product Add(Product obj)
        {
            //INSERT INTO
            _context.Add(obj);
            throw new System.NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }

        public Product Update(Product obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}

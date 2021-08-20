using Entities.Stock;
using Repositories.Data;
using Repositories.Stock.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Stock.Repository
{
    public class ProductRepository : IProductRepository
    {
        //private readonly IDbConnection _context;
        private readonly RepositoryEFContext _context;

        public ProductRepository(RepositoryEFContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product obj)
        {
            try
            {
                await _context.AddAsync(obj);
                await _context.SaveChangesAsync();
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ICollection<Product>> GetAllAsync()
        {
            try
            {
                var responseProducts = _context.Products;
                var response =  responseProducts.ToList();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<Product> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByCodeAsync(long code)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> UpdateAsync(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
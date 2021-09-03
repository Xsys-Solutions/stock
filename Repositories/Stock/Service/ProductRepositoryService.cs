using DTO.Model.Products;
using Entities.Stock;
using Repositories.Stock.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Stock.Service
{
    public class ProductRepositoryService : IProductRepositoryService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductRepositoryValidate _validate;

        public ProductRepositoryService(IProductRepository productRepository, IProductRepositoryValidate validate)
        {
            _productRepository = productRepository;
            _validate = validate;
        }

        public async Task<IEnumerable<ProductResponse>> GetAllAsync()
        {

            List<ProductResponse> listResponse = new();
            try
            {
                IEnumerable<Product> listProduct = await _productRepository.GetAllAsync();
                foreach (Product product in listProduct)
                    listResponse.Add(new()
                    {
                        Id = product.Id,
                        Code = product.Code,
                        Description = product.Description,
                        Amount = product.Amount,
                        Created = product.Created,
                        Updated = product.Updated
                    });

                return listResponse;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProductResponse> CreateAsync(ProductRequest dto)
        {
            try
            {
                if (!_validate.Create(dto))
                    throw new Exception("Erro de validação!");

                Product entity = new()
                {
                    Code = dto.Code,
                    Description = dto.Description,
                };

                _productRepository.CreateAsync(entity);

                return new()
                {
                    Id = entity.Id,
                    Description = entity.Description,
                    Code = entity.Code,
                    Amount = entity.Amount,
                    Created = entity.Created,
                    Updated = entity.Updated,
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ProductResponse> UpdateAsync(ProductRequest obj)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ProductResponse> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductResponse> GetByCodeAsync(long code)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(int productId, int amount)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveAsync(int productId, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
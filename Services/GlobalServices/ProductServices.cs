using DTO.Model.Products;
using GlobalServices.Interface;
using Repositories.Stock.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalServices.GlobalServices
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepositoryService _repositoryService;
        private readonly IProductValidation _validation;

        public ProductServices(IProductRepositoryService repositoryService, IProductValidation validation)
        {
            _repositoryService = repositoryService;
            _validation = validation;
        }

        public async Task<ProductResponse> CreateAsync(ProductRequest request)
        {
            try
            {
                List<string> errros = _validation.Validation(request).ToList();

                if (errros.Count > 0)
                    throw new Exception(string.Format("Service validation error!", request));
                else
                    return await _repositoryService.CreateAsync(request);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<string> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<ProductResponse>> GetAllAsync()
        {
            var listResponse = await _repositoryService.GetAllAsync();
            return listResponse.ToList();
        }

        public Task<ProductResponse> UpdateAsync(ProductRequest obj)
        {
            throw new NotImplementedException();
        }
    }
}
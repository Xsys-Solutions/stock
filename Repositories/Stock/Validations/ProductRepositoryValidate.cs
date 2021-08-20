using DTO.Model.Products;
using Repositories.Stock.Interface;
using System;
using System.Collections.Generic;

namespace Repositories.Stock.Validations
{
    public class ProductRepositoryValidate : IProductRepositoryValidate
    {
        public ProductRepositoryValidate()
        {
            Validates = new List<string>();
        }

        public ICollection<string> Validates { get; set; }
        public bool Create(ProductRequest obj)
        {
            if (obj.Code == 0)
                Validates.Add($"Código inválido: {obj.Code}");

            if (string.IsNullOrWhiteSpace(obj.Description))
                Validates.Add($"Descrição inválido: {obj.Description}");

            return Validates.Count <= 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool GetForCode(long code)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductRequest obj)
        {
            throw new NotImplementedException();
        }
    }
}

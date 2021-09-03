using DTO.Model.Products;
using Services.Interface;
using System.Collections.Generic;

namespace Services.GlobalServices
{
    public class ProductValidation : IProductValidation
    {
        public ICollection<string> Validation(ProductRequest request)
        {
            ICollection<string> Errros = new List<string>();
            if (string.IsNullOrWhiteSpace(request.Description))
                Errros.Add("Descriptions invalid.");
            if (request.Code <= 0)
                Errros.Add("Code invalid.");

            return Errros;
        }
    }
}

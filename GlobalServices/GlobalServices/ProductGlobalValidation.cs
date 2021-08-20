using DTO.Model.Products;
using GlobalServices.Interface;
using System.Collections.Generic;

namespace GlobalServices.GlobalServices
{
    public class ProductGlobalValidation : IProductGlobalValidation
    {
        public ICollection<string> Validation(ProductRequest request)
        {
            ICollection<string> Errros = new List<string>();
            if ( string.IsNullOrWhiteSpace(request.Description))
                Errros.Add("Descriptions invalid.");
            if (request.Code <= 0)
                Errros.Add("Code invalid.");

            return Errros;
        }
    }
}

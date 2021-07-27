using GlobalServices.Interface;

namespace GlobalServices.Facade
{
    public class ProductFacade : IProductFacade
    {
        private readonly IProductGlobalServices _services;

        public ProductFacade(IProductGlobalServices services)
        {
            _services = services;
        }

        public int Remove(int id, int amount)
        {
            if (_services.CheckAmount(id) >= amount)
            {
                _services.Remove(id);
            }

            return _services.CheckAmount(id);
        }
    }
}

using System;
using System.Threading.Tasks;

namespace ShoppingCart.Microservice
{
    public class ShoppingCartCartStore : IShoppingCartStore
    {
        public Task<ShoppingCart> Get()
        {
            return new Task<ShoppingCart>();
        }
    }
}

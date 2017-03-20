using System.Threading.Tasks;

namespace ShoppingCart.Microservice
{
    public interface IShoppingCartStore
    {
       Task<ShoppingCart>  Get();
    }
}
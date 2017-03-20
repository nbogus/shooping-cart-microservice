using Nancy;

namespace ShoppingCart.Microservice
{
    public sealed class ShoppingCartModule : NancyModule
    {
        public ShoppingCartModule(IShoppingCartStore shoppingCartCartStore)
            :base("/shoppingcart")
        {
            Get("/{userid:int}", parameters =>
            {
                var userId = (int) parameters.userid;
                return shoppingCartCartStore.Get();
            });
        }
    }
}

using Entities.Models;

namespace StoreApp.Components
{
    public class CartSummaryViewComponent
    {
        private readonly Cart _cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            _cart = cartService;
        }

        public string Invoke()
        {
            return _cart.Lines.Count.ToString();
        }
    }
}
using Entity.Concrete;
using System.Collections.Generic;

namespace TraversalCore.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}

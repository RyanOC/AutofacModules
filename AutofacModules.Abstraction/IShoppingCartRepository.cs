using AutofacModules.Core;
using System.Collections.Generic;

namespace AutofacModules.Abstraction
{
    public interface IShoppingCartRepository
    {
        void Create(ShoppingCartItem cartItem);
    }
}

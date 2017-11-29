using AutofacModules.Abstraction;
using System;
using AutofacModules.Core;

namespace AutofacModules.Data
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public void Create(ShoppingCartItem cartItem)
        {
            Console.WriteLine("Product Added to Shopping Cart");
            Console.WriteLine("userId:" +cartItem.userId + " product:" + cartItem.product);
        }
    }
}

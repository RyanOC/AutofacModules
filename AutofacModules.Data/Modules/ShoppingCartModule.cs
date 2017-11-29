using Autofac;
using AutofacModules.Abstraction;

namespace AutofacModules.Data.Modules
{
    public class ShoppingCartModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ShoppingCartRepository>().As<IShoppingCartRepository>();
            base.Load(builder);
        }
    }
}
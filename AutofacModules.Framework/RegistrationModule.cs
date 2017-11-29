using Autofac;
using AutofacModules.Data.Modules;

namespace AutofacModules
{
    public class RegistrationModule
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // delegate the registration to the module
            builder.RegisterModule<ShoppingCartModule>();

            //-OR 

            // register the types here
            //builder.RegisterType<AutofacModules.Data.ShoppingCartRepository>().As<AutofacModules.Abstraction.IShoppingCartRepository>();          

            return builder.Build();
        }
    }
}

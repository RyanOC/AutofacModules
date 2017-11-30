using System;
using Autofac;
using AutofacModules.Core;
using AutofacModules.Abstraction;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;

namespace AutofacModules.Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container;

            // use reflection registration

            //ContainerBuilder builder = new ContainerBuilder();

            //string[] assemblyScanerPattern = new[] { @"AutofacModules.*.dll" };

            //// Make sure process paths are sane...
            //Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            //// Scan for assemblies containing autofac modules in the bin folder
            //List<Assembly> assemblies = new List<Assembly>();
            //assemblies.AddRange(
            //    Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "AutofacModules.*.dll", SearchOption.AllDirectories)
            //                .Where(filename => assemblyScanerPattern.Any(pattern => Regex.IsMatch(filename, pattern)))
            //                .Select(Assembly.LoadFrom)
            //    );

            //// register the types
            //foreach (var assembly in assemblies)
            //{
            //    builder.RegisterAssemblyTypes(assembly)
            //        .AsImplementedInterfaces();
            //}

            //container = builder.Build();
            //var proj = container.Resolve<IShoppingCartRepository>();

            //proj.Create(new ShoppingCartItem() { userId = 99, product = "laptop" });

            // end


            container = RegistrationModule.BuildContainer();
            var shoppingCartRepository = container.Resolve<IShoppingCartRepository>();

            shoppingCartRepository.Create(new ShoppingCartItem { userId = 1, product = "laptop" });

            Console.Read();
        }
    }
}

﻿using System;
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

            // test start reflection registration

            //IContainer _container;
            //ContainerBuilder builder = new ContainerBuilder();

            //string[] assemblyScanerPattern = new[] { @"AutofacModules.*.dll" };

            //Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            //List<Assembly> assemblies = new List<Assembly>();
            //assemblies.AddRange(
            //    Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "AutofacModules.*.dll", SearchOption.AllDirectories)
            //        .Where(filename => assemblyScanerPattern.Any(pattern => Regex.IsMatch(filename, pattern)))
            //        .Select(Assembly.LoadFrom)
            //);

            //foreach (var assembly in assemblies)
            //{
            //    builder.RegisterAssemblyTypes(assembly)
            //        .AsImplementedInterfaces();
            //}

            //builder.RegisterType<Data.ProjectRepository>();
            //_container = builder.Build();
            //var proj = _container.Resolve<Data.ProjectRepository>();

            //proj.Create(new Project()
            //{
            //    Id = 33,
            //    Name = "Project 33"
            //}
            //);

            //// end


            var container = RegistrationModule.BuildContainer();

            var projectRepository = container.Resolve<IProjectRepository>();
            var taskRepository = container.Resolve<ITaskRepository>();

            var project = new Project()
            {
                Id = 1,
                Name = "Project 1"
            };
            var task = new Task()
            {
                Id = 1,
                Name = "Task 1"
            };

            projectRepository.Create(project);
            taskRepository.Create(task);

            Console.Read();
        }
    }
}
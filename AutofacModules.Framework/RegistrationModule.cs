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
            builder.RegisterModule<ProjectModule>();
            builder.RegisterModule<TaskModule>();

            //-OR 

            // register the types here
            //builder.RegisterType<AutofacModules.Data.ProjectRepository>().As<AutofacModules.Abstraction.IProjectRepository>();
            //builder.RegisterType<AutofacModules.Data.TaskRepository>().As<AutofacModules.Abstraction.ITaskRepository>();          

            return builder.Build();
        }
    }
}

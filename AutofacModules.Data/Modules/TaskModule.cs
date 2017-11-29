using Autofac;
using AutofacModules.Abstraction;

namespace AutofacModules.Data.Modules
{
    public class TaskModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TaskRepository>().As<ITaskRepository>();
            base.Load(builder);
        }
    }
}

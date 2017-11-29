using Autofac;
using AutofacModules.Abstraction;

namespace AutofacModules.Data.Modules
{
    public class ProjectModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProjectRepository>().As<IProjectRepository>();
            base.Load(builder);
        }
    }
}

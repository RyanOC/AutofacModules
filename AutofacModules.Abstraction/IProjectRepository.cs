using AutofacModules.Core;

namespace AutofacModules.Abstraction
{
    public interface IProjectRepository
    {
        void Create(Project project);
    }
}

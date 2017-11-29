using AutofacModules.Core;

namespace AutofacModules.Abstraction
{
    public interface ITaskRepository
    {
        void Create(Task task);
    }
}

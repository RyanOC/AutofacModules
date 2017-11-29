using System;
using AutofacModules.Abstraction;
using AutofacModules.Core;

namespace AutofacModules.Data
{
    public class TaskRepository : ITaskRepository
    {
        public void Create(Task task)
        {
            Console.WriteLine(task.Id + ": " + task.Name);
        }
    }
}

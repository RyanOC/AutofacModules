using System;
using AutofacModules.Abstraction;
using AutofacModules.Core;

namespace AutofacModules.Data
{
    public class ProjectRepository : IProjectRepository
    {
        public void Create(Project project)
        {
            Console.WriteLine(project.Id + ": " + project.Name);
        }
    }
}

using ToDoList.Business.Concrete;
using ToDoList.Business;
using ToDoList.Core.IoC;
using ToDoList.Core.Business.Abstract;
using ToDoList.Data.Abstract;
using ToDoList.Data.Concrete.EntityFramework;

namespace ToDoList.Application.Bootstrappers
{
    /// <summary>
    /// Dependency bootstrapper
    /// </summary>
    public class DependencyBootstrapper : IBootstrapper
    {
        /// <summary>
        /// Bootstraps dependencies
        /// </summary>
        /// <param name="dependencyContainer"></param>
        public virtual void Bootstrap(IDependencyContainer dependencyContainer)
        {
            dependencyContainer.RegisterTransient<ITaskService, TaskManager>();
            dependencyContainer.RegisterPerThread<ITaskDal, EfTaskDal>();
        }
    }
}

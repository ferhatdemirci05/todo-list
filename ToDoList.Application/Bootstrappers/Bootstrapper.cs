using Autofac;
using ToDoList.Application.Bootstrappers.Autofac;
using ToDoList.Core.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Application.Bootstrappers
{
    /// <summary>
    /// The bootstrapper
    /// </summary>
    public class Bootstrapper
    {
        /// <summary>
        /// Singleton bootstrapper instance
        /// </summary>
        public static readonly Bootstrapper Instance = new Bootstrapper();

        /// <summary>
        /// Initializes a new bootstrapper instance
        /// </summary>
        private Bootstrapper()
        {


            DependencyContainer.Init(new AutofacDependencyContainer());
        }

        /// <summary>
        /// Bootstraps the given bootstrapper using DependencyContainer.Current
        /// </summary>
        /// <param name="bootstrapper"></param>
        /// <returns></returns>
        public Bootstrapper Bootstrap(IBootstrapper bootstrapper)
        {
            bootstrapper.Bootstrap(DependencyContainer.Current);
            return this;
        }
        public void BuildContainer()
        {
            ((AutofacDependencyContainer)DependencyContainer.Current).BuildContainer();
        }
        public IContainer GetContainer()
        {
            return ((AutofacDependencyContainer)DependencyContainer.Current).Container;
        }
        public ContainerBuilder GetContainerBuilder()
        {
            return ((AutofacDependencyContainer)DependencyContainer.Current).Builder;
        }

        /// <summary>
        /// Initializes the DependencyContainer at the application level.
        /// Calling this method invalidates any existing dependency configuration.
        /// This method should only be called for test purposes
        /// </summary>
        public Bootstrapper Reset()
        {

            DependencyContainer.Init(new AutofacDependencyContainer());
            return this;
        }
        public object Resolve(Type type)
        {

            return DependencyContainer.Current.Resolve(type);
        }
    }
}

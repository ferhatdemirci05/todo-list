using ToDoList.Core.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ToDoList.Application.Bootstrappers.Autofac
{

    public class AutofacDependencyContainer : IDependencyContainer
    {
        private IContainer _container;
        private ContainerBuilder _builder;
        private bool isBuild;

        public AutofacDependencyContainer()
        {
            _builder = new ContainerBuilder();

        }

        public IContainer Container
        {
            get
            {

                if (isBuild)
                {
                    return _container;
                }
                else
                {
                    return null;
                }

            }
        }
        public ContainerBuilder Builder
        {
            get
            {
                return _builder;

            }
        }
        public void BuildContainer()
        {
            isBuild = true;
            _container = _builder.Build();
        }
        public IDependencyContainer Register(Type serviceType, Type classType, DependencyScope scope = DependencyScope.Transient, object singleton = null)
        {

            switch (scope)
            {
                case DependencyScope.Transient:
                    _builder.RegisterType(classType).As(serviceType).InstancePerDependency();
                    break;
                case DependencyScope.PerThread:
                    _builder.RegisterType(classType).As(serviceType).InstancePerLifetimeScope();
                    break;
                case DependencyScope.PerWebRequest:
                    _builder.RegisterType(classType).As(serviceType).InstancePerRequest();
                    break;
                case DependencyScope.Singleton:
                    _builder.RegisterType(classType).As(serviceType).SingleInstance();
                    break;

            }






            return this;
        }



        public object Resolve(Type serviceType)
        {
            if (_container != null)
                return _container.Resolve(serviceType);
            else return null;

        }
    }
}

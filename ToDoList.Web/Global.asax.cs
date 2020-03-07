using Autofac.Integration.Mvc;
using ToDoList.Application.Bootstrappers;
using ToDoList.Core.IoC;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

namespace ToDoList.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var bootStrapper = Bootstrapper.Instance;
            var builder = bootStrapper.GetContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            bootStrapper.Bootstrap(new DependencyBootstrapper());
            var dependencyContainer = DependencyContainer.Current;
            bootStrapper.BuildContainer();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(bootStrapper.GetContainer()));
        }
    }
}

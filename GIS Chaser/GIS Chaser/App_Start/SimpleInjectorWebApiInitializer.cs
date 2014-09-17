using GIS_Chaser.Plumbing.TablePlumbings;
using GIS_Chaser.Services.Interfaces;

[assembly: WebActivator.PostApplicationStartMethod(typeof(GIS_Chaser.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace GIS_Chaser.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
//#error Register your services here (remove this line).

            // For instance:
            // container.RegisterWebApiRequest<IUserRepository, SqlUserRepository>();
            container.RegisterSingle<IExtendUserTableStorage, ExtendUserTablePlumbing>();
            container.RegisterSingle<IGemStorage, GemsPlumbing>();
        }
    }
}
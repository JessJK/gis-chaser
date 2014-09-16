using System;
using System.Web;
using GIS_Chaser;
using GIS_Chaser.Models;
using GIS_Chaser.Plumbing.TablePlumbings;
using GIS_Chaser.Services.Interfaces;
using System.Reflection;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Advanced;



//[assembly: WebActivator.PostApplicationStartMethod(typeof(GIS_Chaser.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace GIS_Chaser.App_Start
{
    public static class SimpleInjectorInitializer
    {
        public static Container Initialize(IAppBuilder app)
        {
            var container = GetInitializeContainer(app);
 
            container.Verify();
 
            DependencyResolver.SetResolver(
                new SimpleInjectorDependencyResolver(container));
       
            return container;
        }
 
        public static Container GetInitializeContainer(
                  IAppBuilder app)
        {
            var container = new Container();
 
            container.RegisterSingle<IAppBuilder>(app);

            container.RegisterPerWebRequest<
                   ApplicationUserManager>();
            
            container.RegisterPerWebRequest<ApplicationDbContext>(() 
              => new ApplicationDbContext(
               "Your constring goes here"));
            
            container.RegisterPerWebRequest<IUserStore<
              ApplicationUser>>(() => 
                new UserStore<ApplicationUser>(
                  container.GetInstance<ApplicationDbContext>()));
 
            container.RegisterInitializer<ApplicationUserManager>(
                manager => InitializeUserManager(manager, app));
 
            container.RegisterMvcControllers(
                    Assembly.GetExecutingAssembly());

            container.RegisterPerWebRequest<SignInManager<ApplicationUser, string>, ApplicationSignInManager>();
            container.RegisterPerWebRequest<IAuthenticationManager>(
                () =>
                {
                    IOwinContext context = null;
                    try
                    {
                        context = HttpContext.Current.GetOwinContext();
                    }
                    catch (InvalidOperationException)
                    {
                        // Please note that the `IsVerifying()` method is 
                        // declared in SimpleInjector.Advanced. 
                        if (container.IsVerifying())
                        {
                            return new FakeAuthenticationManager();
                        }
                        throw;
                    }

                    return context.Authentication;
                });


            //App specific container registrations

 
            return container;
        }

        private static void InitializeUserManager(
            ApplicationUserManager manager, IAppBuilder app)
        {
            manager.UserValidator = 
             new UserValidator<ApplicationUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            //Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator()
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };
 
            var dataProtectionProvider = 
                 app.GetDataProtectionProvider();
            
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = 
                 new DataProtectorTokenProvider<ApplicationUser>(
                  dataProtectionProvider.Create("ASP.NET Identity"));
            }
        }
    



        //public static class SimpleInjectorInitializer
        //{
        //    /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        //    public static void Initialize()
        //    {
        //        // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.
        //        var container = new Container();

        //        InitializeContainer(container);

        //        container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

        //        container.Verify();

        //        DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        //    }

        private static void InitializeContainer(Container container)
        {
            //Account container registrations
            container.RegisterPerWebRequest<SignInManager<ApplicationUser, string>, ApplicationSignInManager>();
            container.RegisterPerWebRequest<IAuthenticationManager>(
                () =>
                {
                    IOwinContext context = null;
                    try
                    {
                        context = HttpContext.Current.GetOwinContext();
                    }
                    catch (InvalidOperationException)
                    {
                        // Please note that the `IsVerifying()` method is 
                        // declared in SimpleInjector.Advanced. 
                        if (container.IsVerifying())
                        {
                            return new FakeAuthenticationManager();
                        }
                        throw;
                    }

                    return context.Authentication;
                });


            //App specific container registrations
            container.RegisterSingle<IPointsStorage, PointsPlumbing>();
        }
    }
}

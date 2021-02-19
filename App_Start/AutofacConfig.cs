using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using TelerikMvcTraining.Data;
using TelerikMvcTraining.Data.Repositories;
using TelerikMvcTraining.Services;

namespace TelerikMvcTraining.App_Start
{
    public static class AutofacConfig
    {
        public static void IoCResolve()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<NorthwindDbContext>().InstancePerRequest();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //Register AutoMapper here using AutoFacModule class (Both methods works)
            builder.RegisterModule<AutoFacModule>();

            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<SchedulerTaskService>().InstancePerRequest();

            builder.RegisterType<SchedulerMeetingService>().InstancePerRequest();

            builder.RegisterType<ProductRepositoryMock>().As<IProductRepository>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }  
    }
}

using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using System.Web.Mvc;
using TelerikMvcTraining.AutoMapper;
using TelerikMvcTraining.Data;
using TelerikMvcTraining.Data.Repositories;
using TelerikMvcTraining.Services;

namespace TelerikMvcTraining.App_Start
{
    public static class AutofacContainer 
    {
        public static IMapper Mapper { get; set; }

        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<NorthwindDbContext>().InstancePerRequest();

            // By DI with pluggin AutoMapper.Contrib.Autofac.DependencyInjection
            //builder.RegisterAutoMapper(typeof(MvcApplication).Assembly);

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<SchedulerTaskService>().InstancePerRequest();

            builder.RegisterType<SchedulerMeetingService>().InstancePerRequest();

            builder.RegisterType<ProductRepositoryMock>().As<IProductRepository>();

            MapperConfig();

            builder.Register(c => Mapper).As<IMapper>().SingleInstance();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void MapperConfig()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProductProfile());
                cfg.AddProfile(new CategoryProfile());
            });

            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}
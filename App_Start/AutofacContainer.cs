
using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcTraining.AutoMapper;
using TelerikMvcTraining.Data;
using TelerikMvcTraining.Data.Repositories;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.Services;

namespace TelerikMvcTraining.App_Start
{
    public static class AutofacContainer 
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<NorthwindDbContext>().InstancePerRequest();

            builder.RegisterAutoMapper(typeof(MvcApplication).Assembly);

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<SchedulerTaskService>().InstancePerRequest();

            builder.RegisterType<ProductRepositoryMock>().As<IProductRepository>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
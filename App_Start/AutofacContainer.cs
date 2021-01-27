﻿
using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcTraining.Data;
using TelerikMvcTraining.Data.Repositories;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.App_Start
{
    public static class AutofacContainer 
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register application dependencies.
            builder.RegisterType<ProductRepositoryMock>().As<IProductRepository>();

            builder.RegisterType<NorthwindDbContext>().InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
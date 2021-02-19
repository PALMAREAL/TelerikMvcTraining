﻿using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TelerikMvcTraining.App_Start;
using TelerikMvcTraining.Data;
using TelerikMvcTraining.Data.Repositories;
using TelerikMvcTraining.Services;

namespace TelerikMvcTraining
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutofacConfig.IoCResolve();   
        }
    }
}

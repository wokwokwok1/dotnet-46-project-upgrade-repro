using System;
using Microsoft.Owin;
using Owin;
using System.Security.Claims;
using System.Configuration;
using System.Threading;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using System.ComponentModel.DataAnnotations;
using System.Web.Optimization;
using DemoApp;

[assembly: OwinStartup(typeof(Startup))]

namespace DemoApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DemoApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
        }

        protected void Application_Error(Object sender, EventArgs e)
        {
            var ex = Server.GetLastError();
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }
    }
}
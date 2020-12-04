using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using ChatApp.Controllers;


namespace ChatApp
{
    public class Global : HttpApplication
    {
        public static Controller Control { get; internal set; }

        public Global() : base()
        {
            if (Control == null)
            {
                Control = new Controller();

            }
            else
            {

            }
        }
        void Application_Start(object sender, EventArgs e)
        {
            // Code, der beim Anwendungsstart ausgeführt wird
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
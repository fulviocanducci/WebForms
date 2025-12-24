using Autofac;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebApplication2.Models;

namespace WebApplication2
{
    public class Global : HttpApplication
    {
        public static IContainer Container;
        void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            builder.Register(c =>
                new SqlConnection(ConnectionStrings.SqlServer))
                .InstancePerLifetimeScope();

            builder.RegisterType<DalPeople>()
                   .InstancePerLifetimeScope();

            Container = builder.Build();

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
//using Microsoft.Web.Infrastructure.DynamicModuleHelper;
//using Ninject;
//using Ninject.Web.Common;
//using Ninject.Web.Common.WebHost;
//using System.Data.SqlClient;
//using WebApplication2.Models;

//[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebApplication2.NinjectWebCommon), "Start")]
//[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(WebApplication2.NinjectWebCommon), "Stop")]
//namespace WebApplication2
//{
//    public static class NinjectWebCommon
//    {
//        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

//        public static void Start()
//        {
//            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
//            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
//            bootstrapper.Initialize(CreateKernel);
//        }

//        public static void Stop()
//        {
//            bootstrapper.ShutDown();
//        }

//        private static IKernel CreateKernel()
//        {
//            var kernel = new StandardKernel();
//            RegisterServices(kernel);
//            return kernel;
//        }

//        private static void RegisterServices(IKernel kernel)
//        {
//            kernel.Bind<SqlConnection>()
//                .ToMethod(ctx => new SqlConnection(ConnectionStrings.SqlServer))
//                .InRequestScope();

//            kernel.Bind<DalPeople>()
//                  .ToSelf()
//                  .InRequestScope();
//        }
//    }
//}

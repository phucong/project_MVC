using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Fanex.Data;
using Fanex.Data.SqlServer;
using SimpleInjector;
using ChessResult.Core.Services;
using Fanex.Data.Repository;
using SimpleInjector.Integration.Web.Mvc;

namespace ChessResult.Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static Container container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegisterInstances();

            DbSettingProviderManager
                .StartNewSession()
                .WithSqlServer(resourcePath: "~/App_Data/SPs")
                .Run();
        }

        private void RegisterInstances()
        {
            container = new Container();

            // 2. Configure the container (register)
            // TODO: Em tìm hiểu thêm vụ lifestyle nha
            // Chỗ này là để mình register toàn bộ instance của app
            container.Register<IDynamicRepository, DynamicRepository>(Lifestyle.Singleton);
            container.Register<ITournamentService, TournamentService>(Lifestyle.Singleton);

            // 3. Verify your configuration
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

    }
}
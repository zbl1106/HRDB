using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HRUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //ע������
            var builder = new ContainerBuilder();
            //�ѵ�ǰ�����е� Controller ��ע��
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            Assembly[] assemblies = new Assembly[] { Assembly.Load("HRBLL"), Assembly.Load("HRDAO") };
            builder.RegisterAssemblyTypes(assemblies)
            .AsImplementedInterfaces().PropertiesAutowired();
            var container = builder.Build();
            //ע��ϵͳ����� DependencyResolver�������� MVC ��ܴ��� Controller �ȶ����ʱ���ǹ� Autofac Ҫ����
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));//!!!


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

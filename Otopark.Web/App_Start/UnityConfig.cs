using Otopark.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Otopark.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IBrandService, BrandService>();
            container.RegisterType<ISerieService, SerieService>();
            container.RegisterType<ITariffService, TariffService>();
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<ISellService, SellService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
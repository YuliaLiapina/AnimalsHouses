using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using BusinessLayer;
using BusinessLayer.Interfaces;
using BusinessLayer.InterfacesBL;
using DAL;
using DAL.Interfaces;
using DAL.InterfacesDAL;
using System.Web.Http;
using System.Web.Mvc;

namespace NewAnimalsHouses.Autofac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<AnimalManager>().As<IAnimalManager>();
            builder.RegisterType<HouseManager>().As<IHouseManager>();
            builder.RegisterType<AnimalRepository>().As<IAnimalRepository>();
            builder.RegisterType<HouseRepository>().As<IHouseRepository>();
            builder.RegisterType<JSonConvertor>().As<IJsonConvertor>();


            builder.RegisterModule<MapperAutofacModul>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
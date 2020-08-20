using Autofac;
using AutoMapper;
using BusinessLayer.Models;
using DAL.Models;
using NewAnimalsHouses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewAnimalsHouses.Autofac
{
    public class MapperAutofacModul:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<Animal, AnimalModel>().ReverseMap();
                  cfg.CreateMap<House, HouseModel>().ReverseMap();
                  cfg.CreateMap<AnimalModel, AnimalViewModel>().ReverseMap();
                  cfg.CreateMap<HouseModel, HouseViewModel>().ReverseMap();
                  cfg.CreateMap<AnimalModel, AnimalHouseCommonViewModel>().ReverseMap();
                  cfg.CreateMap<HouseModel, AnimalHouseCommonViewModel>().ReverseMap();
              }
            )).AsSelf().SingleInstance();

            builder.Register(c=>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
        }
    }
}
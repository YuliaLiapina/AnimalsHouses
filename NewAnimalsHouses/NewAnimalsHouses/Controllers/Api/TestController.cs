using AutoMapper;
using BusinessLayer;
using BusinessLayer.Models;
using NewAnimalsHouses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewAnimalsHouses.Controllers.Api
{
    public class TestController : ApiController
    {
        public AnimalManager _animalManager;

        public HouseManager _houseManager;

        public JSonConvertor _jsonConvertor;

        private Mapper _mapper;
        public TestController()
        {
            _animalManager = new AnimalManager();
            _houseManager = new HouseManager();
            _jsonConvertor = new JSonConvertor();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>().ReverseMap();
                cfg.CreateMap<HouseModel, HouseViewModel>().ReverseMap();
                cfg.CreateMap<HouseModel, AnimalHouseCommonViewModel>().ReverseMap();
                cfg.CreateMap<AnimalModel, AnimalHouseCommonViewModel>().ReverseMap();
            });
            _mapper = new Mapper(conf);
        }
        // GET: api/Test

        public string Get()
        {
            var animals = _animalManager.GetAll();
            var json = _jsonConvertor.Convert(animals);

            return json;
        }
        //public IEnumerable<AnimalViewModel> Get()
        //{
        //    var animals = _animalManager.GetAll();

        //    IEnumerable<AnimalViewModel> result = _mapper.Map<IList<AnimalViewModel>>(animals);

        //    return result;
        //}

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}

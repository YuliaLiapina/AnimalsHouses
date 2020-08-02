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
    public class HousesController : ApiController
    {
        private readonly HouseManager _houseManager;

        private readonly JSonConvertor _jsonConvertor;

        private Mapper _mapper;
        public HousesController()
        {
            _houseManager = new HouseManager();
            _jsonConvertor = new JSonConvertor();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>().ReverseMap();
                cfg.CreateMap<HouseModel, HouseViewModel>().ReverseMap();
            });
            _mapper = new Mapper(conf);
        }
        // GET: api/Houses
        public string Get()
        {
            var houses = _houseManager.GetAll();
            var housesViewModel = _mapper.Map<IList<HouseViewModel>>(houses);
            var json = _jsonConvertor.Convert(housesViewModel);

            return json;
        }

        // GET: api/Houses/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Houses
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Houses/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Houses/5
        public void Delete(int id)
        {
        }
    }
}

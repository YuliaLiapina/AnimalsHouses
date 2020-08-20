using AutoMapper;
using BusinessLayer;
using BusinessLayer.InterfacesBL;
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
        private readonly IAnimalManager _animalManager;
        private readonly JSonConvertor _jsonConvertor;
        private readonly IMapper _mapper;
        public TestController(IAnimalManager animalManager, IHouseManager houseManager, IMapper mapper)
        {
            _animalManager = animalManager;
            _jsonConvertor = new JSonConvertor();
            _mapper = mapper;
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

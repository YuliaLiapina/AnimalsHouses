using AutoMapper;
using BusinessLayer;
using BusinessLayer.Interfaces;
using BusinessLayer.InterfacesBL;
using NewAnimalsHouses.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace NewAnimalsHouses.Controllers.Api
{
    public class HousesController : ApiController
    {
        private readonly IHouseManager _houseManager;
        private readonly IJsonConvertor _jsonConvertor;
        private readonly IMapper _mapper;
        public HousesController(IHouseManager houseManager, IMapper mapper, IJsonConvertor jsonConvertor)
        {
            _houseManager = houseManager;
            _mapper = mapper;
            _jsonConvertor = jsonConvertor;
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

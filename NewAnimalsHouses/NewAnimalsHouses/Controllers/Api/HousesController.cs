using BusinessLayer;
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
        public readonly HouseManager _houseManager;

        public readonly JSonConvertor _jsonConvertor;
        public HousesController()
        {
            _houseManager = new HouseManager();
            _jsonConvertor = new JSonConvertor();
        }
        // GET: api/Houses
        public string Get()
        {
            var houses = _houseManager.GetAll();
            var json = _jsonConvertor.Convert(houses);

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

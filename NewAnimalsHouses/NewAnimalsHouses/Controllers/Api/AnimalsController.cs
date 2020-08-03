using AutoMapper;
using BusinessLayer;
using BusinessLayer.Models;
using NewAnimalsHouses.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace NewAnimalsHouses.Controllers.Api
{
    public class AnimalsController : ApiController
    {
        private readonly AnimalManager _animalManager;

        private readonly JSonConvertor _jsonConvertor;

        private Mapper _mapper;
        public AnimalsController()
        {
            _animalManager = new AnimalManager();
            _jsonConvertor = new JSonConvertor();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>().ReverseMap();
                cfg.CreateMap<HouseModel, HouseViewModel>().ReverseMap();
            });
            _mapper = new Mapper(conf);

        }
        // GET: api/Animals

        public string Get()
        {
            var animals = _animalManager.GetAll();
            var animalsViewModel = _mapper.Map<IList<AnimalViewModel>>(animals);
                        
            var json = _jsonConvertor.Convert(animalsViewModel);

            return json;
        }


        // GET: api/Animals/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Animals
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Animals/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Animals/5
        public void Delete(int id)
        {
        }
    }
}

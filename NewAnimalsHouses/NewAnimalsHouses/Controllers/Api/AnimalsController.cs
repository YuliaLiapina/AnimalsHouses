﻿using AutoMapper;
using BusinessLayer;
using BusinessLayer.Interfaces;
using BusinessLayer.InterfacesBL;
using BusinessLayer.Models;
using NewAnimalsHouses.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace NewAnimalsHouses.Controllers.Api
{
    public class AnimalsController : ApiController
    {
        private readonly IAnimalManager _animalManager;
        private readonly IMapper _mapper;
        private readonly IJsonConvertor _jsonConvertor;

        public AnimalsController(IAnimalManager animalManager, IMapper mapper, IJsonConvertor jsonConvertor)
        {
            _animalManager = animalManager;
            _mapper = mapper;
            _jsonConvertor = jsonConvertor;
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

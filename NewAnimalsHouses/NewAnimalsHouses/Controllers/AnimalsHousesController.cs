using AutoMapper;
using BusinessLayer;
using BusinessLayer.Models;
using NewAnimalsHouses.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NewAnimalsHouses.Controllers
{
    public class AnimalsHousesController : Controller
    {
        public AnimalManager _animalManager;

        public HouseManager _houseManager;

        private Mapper _mapper;
        public AnimalsHousesController()
        {
            _animalManager = new AnimalManager();
            _houseManager = new HouseManager();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>().ReverseMap();
                cfg.CreateMap<HouseModel, HouseViewModel>().ReverseMap();
            });
            _mapper = new Mapper(conf);
        }
        // GET: Animal
        public ActionResult Animal()
        {
            var listAnimals = _animalManager.GetAll();

            var result = new GetAllAnimalsViewModel();

            result.AllAnimals = _mapper.Map<IList<AnimalViewModel>>(listAnimals);

            return View(result);
        }

        public ActionResult House()
        {
            var listHouses = _houseManager.GetAll();

            var result = new GetAllHousesViewModel();

            result.AllHouses = _mapper.Map<IList<HouseViewModel>>(listHouses);

            return View(result);
        }
    }
}
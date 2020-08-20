using AutoMapper;
using BusinessLayer.InterfacesBL;
using BusinessLayer.Managers;
using DAL.Models;
using Microsoft.AspNet.Identity.Owin;
using NewAnimalsHouses.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NewAnimalsHouses.Controllers
{
    public class AnimalsHousesController : Controller
    {
        private readonly IAnimalManager _animalManager;
        private readonly IHouseManager _houseManager;
        private readonly IMapper _mapper;

        //public AnimalManager _animalManager;
        //public HouseManager _houseManager;
        //private readonly Mapper _mapper;
        public AnimalsHousesController(IAnimalManager animalManager, IHouseManager houseManager, IMapper mapper)
        {
            _animalManager = animalManager;
            _houseManager = houseManager;
            _mapper = mapper;
            //_animalManager = new AnimalManager();
            //_houseManager = new HouseManager();
            //var conf = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<AnimalModel, AnimalViewModel>().ReverseMap();
            //    cfg.CreateMap<HouseModel, HouseViewModel>().ReverseMap();
            //    cfg.CreateMap<HouseModel, AnimalHouseCommonViewModel>().ReverseMap();
            //    cfg.CreateMap<AnimalModel, AnimalHouseCommonViewModel>().ReverseMap();
            //});
            //_mapper = new Mapper(conf);
        }
        // GET: Animal
                 
        public async Task<ActionResult> Animal()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();

            var listAnimals = _animalManager.GetAll();

            var result = new AnimalHouseCollectionViewModel();

            result.CommonViewModel = _mapper.Map<IList<AnimalHouseCommonViewModel>>(listAnimals);

            var createUser = await userManager.CreateAsync(new Employee
            {
                LastName = "Julia",
                Email = "Julia@gmail.com",
                UserName = "Juli",
                BirthDate = new DateTime(2020,07,30)
            }, "123456789");


            return View(result);
        }

        public ActionResult House()
        {
            var listHouses = _houseManager.GetAll();

            var result = new AnimalHouseCollectionViewModel();

            result.CommonViewModel = _mapper.Map<IList<AnimalHouseCommonViewModel>>(listHouses);
            
            return View(result);
        }

        

        //public ActionResult Animal()
        //{
        //    var listAnimals = _animalManager.GetAll();

        //    var result = new GetAllAnimalsViewModel();

        //    result.AllAnimals = _mapper.Map<IList<AnimalViewModel>>(listAnimals);

        //    return View(result);
        //}

        //public ActionResult House()
        //{
        //    var listHouses = _houseManager.GetAll();

        //    var result = new GetAllHousesViewModel();

        //    result.AllHouses = _mapper.Map<IList<HouseViewModel>>(listHouses);

        //    return View(result);
        //}
    }
}
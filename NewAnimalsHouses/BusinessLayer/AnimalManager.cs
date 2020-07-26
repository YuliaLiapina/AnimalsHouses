using AutoMapper;
using BusinessLayer.Models;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class AnimalManager
    {
        public readonly AnimalRepository _animalRepository;

        private readonly Mapper _mapper;
        public AnimalManager()
        {
            _animalRepository = new AnimalRepository();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Animal, AnimalModel>().ReverseMap();
                cfg.CreateMap<House, HouseModel>().ReverseMap();
            });
            _mapper = new Mapper(conf);
        }

        public IList<AnimalModel> GetAll()
        {
            var listAnimals = _animalRepository.GetAll();

            var result = _mapper.Map<IList<AnimalModel>>(listAnimals);
            
            return result;
        }
    }
}

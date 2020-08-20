using AutoMapper;
using BusinessLayer.InterfacesBL;
using BusinessLayer.Models;
using DAL;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class AnimalManager:IAnimalManager
    {
        private readonly IAnimalRepository _animalRepository;
        private readonly IMapper _mapper;
        public AnimalManager(IAnimalRepository animalRepository, IMapper mapper)
        {
            _animalRepository = animalRepository;
            _mapper = mapper;
        }

        public IList<AnimalModel> GetAll()
        {
            var listAnimals = _animalRepository.GetAll();

            var result = _mapper.Map<IList<AnimalModel>>(listAnimals);
            
            return result;
        }
    }
}

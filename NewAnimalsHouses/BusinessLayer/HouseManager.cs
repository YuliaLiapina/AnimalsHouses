using AutoMapper;
using BusinessLayer.Models;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class HouseManager
    {
        public readonly HouseRepository _houseRepository;

        private readonly Mapper _mapper;
        public HouseManager()
        {
            _houseRepository = new HouseRepository();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<House, HouseModel>().ReverseMap();
                cfg.CreateMap<Animal, AnimalModel>().ReverseMap();
            });
            _mapper = new Mapper(conf);
        }

        public IList<HouseModel> GetAll()
        {
            var listHouses = _houseRepository.GetAll();

            var result = _mapper.Map<IList<HouseModel>>(listHouses);

            return result;
        }
    }
}

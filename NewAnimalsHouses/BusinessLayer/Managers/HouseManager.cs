using AutoMapper;
using BusinessLayer.InterfacesBL;
using BusinessLayer.Models;
using DAL;
using DAL.InterfacesDAL;
using DAL.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class HouseManager:IHouseManager
    {
        private readonly IHouseRepository _houseRepository;
        private readonly IMapper _mapper;
        public HouseManager(IHouseRepository houseRepository, IMapper mapper)
        {
            _houseRepository = houseRepository;
            _mapper = mapper;
        }

        public IList<HouseModel> GetAll()
        {
            var listHouses = _houseRepository.GetAll();

            var result = _mapper.Map<IList<HouseModel>>(listHouses);

            return result;
        }

        public HouseModel CreateHouse(HouseModel house)
        {
            var result = _mapper.Map<House>(house);
            var result2 = _houseRepository.CreateHouse(result);
            var resultMap = _mapper.Map<HouseModel>(result2);

            return resultMap;
        }
    }
}

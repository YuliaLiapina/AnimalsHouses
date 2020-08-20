using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.InterfacesBL
{
    public interface IHouseManager
    {
        IList<HouseModel> GetAll();
        HouseModel CreateHouse(HouseModel house);
    }
}

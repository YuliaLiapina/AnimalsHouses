using DAL.Models;
using System.Collections.Generic;

namespace DAL.InterfacesDAL
{
    public interface IHouseRepository
    {
        IList<House> GetAll();
        House CreateHouse(House house);
    }
}

using DAL.InterfacesDAL;
using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace DAL
{
    public class HouseRepository:IHouseRepository
    {
        public IList<House> GetAll()
        {
            using (var context = new AnimalsHousesContext())
            {
                var listHouses = context.Houses./*Include(house => house.Animals).*/ToList();

                return listHouses;
            }
        }

        public House CreateHouse(House house)
        {
            using(var context = new AnimalsHousesContext())
            {
                context.Houses.Add(house);
                context.SaveChanges();
                return house;
            }
        }
    }
}

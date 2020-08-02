using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace DAL
{
    public class HouseRepository
    {
        public IList<House> GetAll()
        {
            using (var context = new AnimalsHousesContext())
            {
                var listHouses = context.Houses./*Include(house => house.Animals).*/ToList();

                return listHouses;
            }
        }
    }
}

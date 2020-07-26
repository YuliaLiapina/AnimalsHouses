using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class AnimalRepository
    {
        public IList<Animal> GetAll()
        {
            using (var context = new AnimalsHousesContext())
            {
                var listAnimals = context.Animals.Include(animal=>animal.House).ToList();

                return listAnimals;
            }
        }
    }
}

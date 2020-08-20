using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class AnimalRepository:IAnimalRepository
    {
        public IList<Animal> GetAll()
        {
            using (var context = new AnimalsHousesContext())
            {
                var listAnimals = context.Animals./*Include(animal=>animal.House).*/ToList();

                return listAnimals;
            }
        }
    }
}

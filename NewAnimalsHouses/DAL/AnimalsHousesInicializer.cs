using DAL.Models;
using System.Data.Entity;
namespace DAL
{
   public class AnimalsHousesInicializer: CreateDatabaseIfNotExists<AnimalsHousesContext>
    {
        protected override void Seed(AnimalsHousesContext context)
        {
            var cat = new Animal() { Name = "Cat", Age = 10};
            var dog = new Animal() { Name = "Dog", Age = 20 };
            var bird = new Animal() { Name = "Bird", Age = 20 };

            var house1 = new House() { Name = "House1" };
            var house2 = new House() { Name = "House2" };
            
            house1.Animals.Add(cat);
            house2.Animals.Add(dog);
            house2.Animals.Add(bird);

            context.Animals.Add(cat);
            context.Animals.Add(dog);
            context.Animals.Add(bird);

            context.Houses.Add(house1);
            context.Houses.Add(house2);

            context.SaveChanges();
        }
    }
}

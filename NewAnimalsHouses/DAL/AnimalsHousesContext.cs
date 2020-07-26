using DAL.Models;
using System.Data.Entity;

namespace DAL
{
   public class AnimalsHousesContext: DbContext
    {
        public AnimalsHousesContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new AnimalsHousesInicializer());
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<House> Houses { get; set; }
    }
}

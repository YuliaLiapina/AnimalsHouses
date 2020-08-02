using DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DAL
{
   public class AnimalsHousesContext: IdentityDbContext<Employee>
    {
        public AnimalsHousesContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new AnimalsHousesInicializer());
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<House> Houses { get; set; }
    }
}

using DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Common;
using System.Data.Entity;

namespace DAL
{
   public class AnimalsHousesContext: IdentityDbContext<Employee>
    {
        public AnimalsHousesContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new AnimalsHousesInicializer());
        }
        public AnimalsHousesContext(DbConnection connection):base(connection, false)
        {

        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<House> Houses { get; set; }
    }
}

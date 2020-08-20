using DAL;
using DAL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace BusinessLayer.Managers
{
   public class EmployeeManager:UserManager<Employee>
    {
        public EmployeeManager(IUserStore<Employee> store) : base(store) { }  

        public static EmployeeManager Create(IdentityFactoryOptions<EmployeeManager> options, IOwinContext context)
        {
            AnimalsHousesContext db = context.Get<AnimalsHousesContext>();
            EmployeeManager manager = new EmployeeManager(new UserStore<Employee>(db));

            return manager;
        }
    }
}

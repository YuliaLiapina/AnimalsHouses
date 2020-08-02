using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee:IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string LastName { get; set; }
    }
}

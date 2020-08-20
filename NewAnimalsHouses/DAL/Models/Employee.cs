using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace DAL.Models
{
    public class Employee:IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string LastName { get; set; }
        public string Language { get; set; }
    }
}

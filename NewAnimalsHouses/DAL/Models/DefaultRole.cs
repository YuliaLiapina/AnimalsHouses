using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DefaultRole:IdentityRole
    {
        public DefaultRole():base()
        {

        }
        public DefaultRole(string name) : base(name)
        {

        }
    }
}

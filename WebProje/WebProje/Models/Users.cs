using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Users:IdentityUser
    {

        public string Name { get; set; }
        public string LastName { get; set; }

        //public string UserName { get; set; }

    

        public string Phone { get; set; }

    }
}

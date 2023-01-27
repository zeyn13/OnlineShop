using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace OnlineShop.Models
{
    public class AplicationUser:IdentityUser
    {

        public string FirsName { get; set; }

        public string LastName { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String FullName { get; set; }

        public DateTime BirthDay { get; set; }
    }
}

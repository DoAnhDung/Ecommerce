using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace ECommerceApp.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // Add custom user properties here
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

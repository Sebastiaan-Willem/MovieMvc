using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMvc.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string FavouriteGenre { get; set; }
        public bool IsRegularCustomer { get; set; }
    }
}

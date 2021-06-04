using Bookstore.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class ApplicationUser: IdentityUser
    {
        public Book FavouriteBook  { get; set; }
        public Genre FavouriteGenre { get; set; }
        public DateTime LoggedInSince { get; set; }
    }
}

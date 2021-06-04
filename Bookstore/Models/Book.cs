using Bookstore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public Genre Genre { get; set; }
        public string Author { get; set; }
        public DateTime YearOfRelease { get; set; }
        public bool IsAdult { get; set; }
    }
}

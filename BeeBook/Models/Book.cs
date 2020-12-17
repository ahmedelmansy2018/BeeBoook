using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeBook.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsBookOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

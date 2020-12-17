using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeBook.Models;

namespace BeeBook.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public string CurrentCategory { get; set; }
    }
}

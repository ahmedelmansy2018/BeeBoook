using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeBook.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> AllBooks { get; }
        IEnumerable<Book> BooksOfTheWeek { get; }
        Book GetBookById(int BookId);
    }
}

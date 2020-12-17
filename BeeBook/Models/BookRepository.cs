using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeBook.Data;
using Microsoft.EntityFrameworkCore;

namespace BeeBook.Models
{
    public class BookRepository: IBookRepository
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public BookRepository(ApplicationDbContext ApplicationDbContext)
        {
            _ApplicationDbContext = ApplicationDbContext;
        }

        public IEnumerable<Book> AllBooks
        {
            get
            {
                return _ApplicationDbContext.Books.Include(c => c.Category);
            }
        }

        public IEnumerable<Book> BooksOfTheWeek
        {
            get
            {
                return _ApplicationDbContext.Books.Include(c => c.Category).Where(p => p.IsBookOfTheWeek);
            }
        }

        public Book GetBookById(int BookId)
        {
            return _ApplicationDbContext.Books.FirstOrDefault(p => p.BookId == BookId);
        }
    }
}

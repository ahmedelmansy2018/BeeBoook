using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeBook.Models;
using BeeBook.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeeBook.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _BookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BookController(IBookRepository BookRepository, ICategoryRepository categoryRepository)
        {
            _BookRepository = BookRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        //public IActionResult List()
        //{
        //    //ViewBag.CurrentCategory = "Cheese cakes";

        //    //return View(_BookRepository.AllBooks);
        //    BooksListViewModel BooksListViewModel = new BooksListViewModel();
        //    BooksListViewModel.Books = _BookRepository.AllBooks;

        //    BooksListViewModel.CurrentCategory = "Cheese cakes";
        //    return View(BooksListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Book> Books;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                Books = _BookRepository.AllBooks.OrderBy(p => p.BookId);
                currentCategory = "All Books";
            }
            else
            {
                Books = _BookRepository.AllBooks.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.BookId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new BooksListViewModel
            {
                Books = Books,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var Book = _BookRepository.GetBookById(id);
            if (Book == null)
                return NotFound();

            return View(Book);
        }
    }
}

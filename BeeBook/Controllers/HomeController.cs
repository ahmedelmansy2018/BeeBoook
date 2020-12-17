using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeeBook.Models;
using BeeBook.ViewModels;

namespace BeeBook.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBookRepository _BookRepository;

        public HomeController(IBookRepository BookRepository)
        {
            _BookRepository = BookRepository;
        }
       
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BooksOfTheWeek = _BookRepository.BooksOfTheWeek
            };

            return View(homeViewModel);
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

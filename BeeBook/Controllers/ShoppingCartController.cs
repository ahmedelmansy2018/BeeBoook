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
    public class ShoppingCartController : Controller
    {
        private readonly IBookRepository _BookRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBookRepository BookRepository, ShoppingCart shoppingCart)
        {
            _BookRepository = BookRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int BookId)
        {
            var selectedBook = _BookRepository.AllBooks.FirstOrDefault(p => p.BookId == BookId);

            if (selectedBook != null)
            {
                _shoppingCart.AddToCart(selectedBook, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int BookId)
        {
            var selectedBook = _BookRepository.AllBooks.FirstOrDefault(p => p.BookId == BookId);

            if (selectedBook != null)
            {
                _shoppingCart.RemoveFromCart(selectedBook);
            }
            return RedirectToAction("Index");
        }
    }
}

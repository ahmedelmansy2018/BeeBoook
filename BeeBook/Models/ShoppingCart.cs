using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeBook.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BeeBook.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(ApplicationDbContext ApplicationDbContext)
        {
            _ApplicationDbContext = ApplicationDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Book Book, int amount)
        {
            var shoppingCartItem =
                    _ApplicationDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Book.BookId == Book.BookId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Book = Book,
                    Amount = 1
                };

                _ApplicationDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _ApplicationDbContext.SaveChanges();
        }

        public int RemoveFromCart(Book Book)
        {
            var shoppingCartItem =
                    _ApplicationDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Book.BookId == Book.BookId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _ApplicationDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _ApplicationDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _ApplicationDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Book)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _ApplicationDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _ApplicationDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _ApplicationDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _ApplicationDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Book.Price * c.Amount).Sum();
            return total;
        }
    }
}

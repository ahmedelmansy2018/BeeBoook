using BeeBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeBook.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _ApplicationDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(ApplicationDbContext ApplicationDbContext, ShoppingCart shoppingCart)
        {
            _ApplicationDbContext = ApplicationDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    BookId = shoppingCartItem.Book.BookId,
                    Price = shoppingCartItem.Book.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _ApplicationDbContext.Orders.Add(order);

            _ApplicationDbContext.SaveChanges();
        }
    }
}

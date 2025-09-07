using System.Collections.Generic;
using System.Linq;
using Book.Services;

namespace Book.Services
{
    public class CartService
    {
        private readonly List<Book> _cart = new();

        public List<Book> GetCartBooks() => _cart;

        public void AddToCart(Book book)
        {
            _cart.Add(book);
        }

        public void RemoveFromCart(Book book)
        {
            _cart.Remove(book);
        }

        public decimal GetTotalPrice() => _cart.Sum(b => b.Price);

        public void ClearCart() => _cart.Clear();
    }
}


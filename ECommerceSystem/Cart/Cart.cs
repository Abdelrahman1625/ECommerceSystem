using ECommerceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Cart
{
    public class Cart
    {
        private List<CartItem> items = new();

        public void Add(Product product, int quantity)
        {
            if (quantity > product.Quantity)
                throw new Exception($"Not enough quantity for product {product.Name}");

            items.Add(new CartItem(product, quantity));
        }

        public IReadOnlyList<CartItem> Items => items;
        public bool IsEmpty => !items.Any();
    }
}

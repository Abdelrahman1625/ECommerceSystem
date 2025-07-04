using ECommerceSystem.Interfaces;
using ECommerceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Services
{
    public static class CheckoutProcessor
    {
        public static void Checkout(Customer customer, Cart.Cart cart)
        {
            if (cart.IsEmpty)
                throw new Exception("Cart is empty.");

            List<IShippable> shippableItems = new();
            double subtotal = 0;

            foreach (var item in cart.Items)
            {
                var product = item.Product;

                if (product.IsExpired())
                    throw new Exception($"Product {product.Name} is expired.");

                if (product.Quantity < item.Quantity)
                    throw new Exception($"Not enough stock for {product.Name}.");

                product.Quantity -= item.Quantity;
                subtotal += item.TotalPrice;

                if (product is IShippable shippable)
                    for (int i = 0; i < item.Quantity; i++)
                        shippableItems.Add(shippable);
            }

            double shippingFee = shippableItems.Any() ? 30 : 0;
            double total = subtotal + shippingFee;

            customer.Deduct(total);

            if (shippableItems.Any())
                ShippingService.ShipItems(shippableItems);

            Console.WriteLine(" Checkout ");
            foreach (var item in cart.Items)
                Console.WriteLine($"{item.Quantity}x {item.Product.Name,-12} {item.TotalPrice}");

            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal         {subtotal}");
            Console.WriteLine($"Shipping         {shippingFee}");
            Console.WriteLine($"Amount           {total}");
            Console.WriteLine($"Balance left     {customer.Balance}\n");
        }
    }
}

using ECommerceSystem.Models;
using ECommerceSystem.Services;

namespace ECommerceSystem
{
    internal class Program
    {
        static void Main()
        {
            var cheese = new ExpirableShippableProduct("Cheese", 100, 10, DateTime.Now.AddDays(1), 0.2);
            var biscuits = new ExpirableProduct("Biscuits", 150, 5, DateTime.Now.AddDays(2));
            var phone = new ShippableProduct("Phone", 1000, 3, 10);
            var scratchCard = new SimpleProduct("ScratchCard", 50, 20);

            var customer = new Customer("Amr Ahmed", 10000);
            var cart = new ECommerceSystem.Cart.Cart();

            cart.Add(cheese, 4);
            cart.Add(biscuits, 2);
            cart.Add(phone, 1);
            cart.Add(scratchCard, 3);

            try
            {
                CheckoutProcessor.Checkout(customer, cart);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex.Message}");
            }
        }
    }
}

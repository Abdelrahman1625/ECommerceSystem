using ECommerceSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Services
{
    public static class ShippingService
    {
        public static void ShipItems(List<IShippable> items)
        {
            Console.WriteLine(" Shipment ");

            double totalWeight = 0;
            foreach (var item in items)
            {
                Console.WriteLine($"{item.GetName(),-15} {item.GetWeight() * 1000}g");
                totalWeight += item.GetWeight();
            }

            Console.WriteLine($"Total weight {totalWeight}kg\n");
        }
    }
}

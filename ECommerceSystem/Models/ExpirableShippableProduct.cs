using System;
using ECommerceSystem.Interfaces;

namespace ECommerceSystem.Models
{
    public class ExpirableShippableProduct : ExpirableProduct, IShippable
    {
        public double Weight { get; set; }

        public ExpirableShippableProduct(string name, double price, int quantity, DateTime expiryDate, double weight)
            : base(name, price, quantity, expiryDate)
        {
            Weight = weight;
        }

        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}

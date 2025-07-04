using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public void Deduct(double amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient balance.");
            Balance -= amount;
        }
    }
}

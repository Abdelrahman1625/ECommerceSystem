# ECommerceSystem
A simple, console‑based e-commerce application written in C# (.NET), built to demonstrate:

Product management (name, price, stock quantity)

Expirable products (e.g., Cheese, Biscuits)

Shippable products (e.g., TVs, Cheese)

Shopping cart with quantity validation

Secure checkout:

Prevents empty carts, expired items, insufficient stock, or low balance

Calculates subtotal, shipping fee, total, and updates customer balance

Produces a shipping notice and receipt summary

🛠️ Features
Product types

Product (abstract base)

ExpirableProduct (tracks expiry date)

ShippableProduct (tracks weight, implements IShippable)

ExpirableShippableProduct (combines both)

Cart functionality

Add items with quantity checks

Holds a list of CartItem (product + desired quantity)

Checkout logic

Validates cart state and item availability

Applies shipping fee (e.g., 30) if any cart item is shippable

Deducts from customer's balance, prints shipment notice & receipt

Extensibility

Clean folder structure: Interfaces, Models, Services, Cart

Easily extendable for non-expirable or non-shippable products

🚀 Getting Started
Prerequisites
.NET 6.0+ SDK (or newer)

Visual Studio, VS Code, or any preferred C# IDE

Running the Project
Clone the repository
git clone https://github.com/Abdelrahman1625/ECommerceSystem.git
cd ECommerceSystem
Run using Visual Studio

Open ECommerceSystem.sln

Restore NuGet packages if prompted

Set the project as startup

Press F5 or Ctrl + F5

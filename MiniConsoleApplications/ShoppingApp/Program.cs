using System;
using System.Collections.Generic;

namespace commerse;
using Ecommerse;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product("Laptop", 1000, 1));
        products.Add(new Product("Headphone", 10000, 3));
        products.Add(new Product("Mobile", 20000, 2));
        products.Add(new Product("Charger", 3000, 1));

        // Create Cart object
        Cart cart = new Cart();

        while (true)
        {
            Console.WriteLine("\n===== E-Commerce Menu =====");
            Console.WriteLine("1. Add Product to Cart");
            Console.WriteLine("2. Remove Product from Cart");
            Console.WriteLine("3. Display Cart");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Your Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.WriteLine("\nAvailable Products:");

                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine(
                            $"{i + 1}. {products[i].GetProductName()} | Price: {products[i].GetPrice()} | Quantity: {products[i].GetQuantity()}"
                        );
                    }

                    Console.Write("Enter Product Number: ");
                    int productNumberToAdd = Convert.ToInt32(Console.ReadLine());

                    if (productNumberToAdd >= 1 && productNumberToAdd <= products.Count)
                    {
                        cart.AddProduct(products[productNumberToAdd - 1]);

                        Console.WriteLine(
                            $"{products[productNumberToAdd - 1].GetProductName()} added to cart."
                        );
                    }
                    else
                    {
                        Console.WriteLine("Invalid Product Number.");
                    }

                    break;

                case 2:

                    cart.DisplayCart();

                    Console.Write("Enter Product Name to Remove: ");
                    string productNameToRemove = Console.ReadLine();

                    Product productToRemove = products.Find(
                        p => p.GetProductName()
                              .Equals(productNameToRemove, StringComparison.OrdinalIgnoreCase)
                    );

                    if (productToRemove != null)
                    {
                        cart.RemoveProduct(productToRemove);

                        Console.WriteLine(
                            $"{productToRemove.GetProductName()} removed from cart."
                        );
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }

                    break;

                case 3:

                    cart.DisplayCart();
                    break;

                case 4:

                    Console.WriteLine("Thank you for shopping!");
                    return;

                default:

                    Console.WriteLine("Invalid Choice. Please Try Again.");
                    break;
            }
        }
    }
}
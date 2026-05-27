using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First customer (USA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P100", 800, 1),
            new Product("Mouse", "P101", 25, 2),
            new Product("Keyboard", "P102", 45, 1)
        };

        Order order1 = new Order(products1, customer1);

        // Second customer (Outside USA)
        Address address2 = new Address(
            "45 Oxford Road",
            "London",
            "Greater London",
            "United Kingdom"
        );

        Customer customer2 = new Customer("Emma Brown", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Phone", "P200", 600, 1),
            new Product("Headphones", "P201", 80, 2)
        };

        Order order2 = new Order(products2, customer2);

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine("------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n============================\n");

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine("------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)
        Address address1 = new Address("12 Freedom St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Michael Johnson", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P001", 1200, 1),
            new Product("Mouse", "P002", 25, 2),
            new Product("Keyboard", "P003", 50, 1)
        };

        Order order1 = new Order(products1, customer1);

        // Order 2 (International Customer)
        Address address2 = new Address("88 Oxford Road", "London", "London", "UK");
        Customer customer2 = new Customer("Sarah Williams", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Phone", "P010", 800, 1),
            new Product("Headphones", "P011", 120, 2)
        };

        Order order2 = new Order(products2, customer2);

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n====================\n");

        // Display Order 2
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}

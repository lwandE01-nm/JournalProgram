using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ===== Order 1 =====
        Address address1 = new Address("12 Main Street", "Mbabane", "Hhohho", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Book", "B001", 50, 2),
            new Product("Pen", "P001", 5, 10),
            new Product("Bag", "B002", 200, 1)
        };

        Order order1 = new Order(products1, customer1);

        // ===== Order 2 =====
        Address address2 = new Address("88 Oxford Road", "London", "London", "UK");
        Customer customer2 = new Customer("Emma Brown", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Phone", "P100", 800, 1),
            new Product("Headphones", "H200", 120, 2)
        };

        Order order2 = new Order(products2, customer2);

        // ===== Display Order 1 =====
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n====================\n");

        // ===== Display Order 2 =====
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}

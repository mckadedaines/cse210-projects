using System;

class Program
{
    static void Main()
    {
        // Create customers and their addresses
        var customer1 = new Customer("John Doe", new Address("123 Main St", "Springfield", "IL", "USA"));
        var customer2 = new Customer("Jane Smith", new Address("456 Elm St", "Toronto", "ON", "Canada"));

        // Create products
        var product1 = new Product("Widget", 101, 19.99m, 2);
        var product2 = new Product("Gadget", 202, 29.99m, 1);
        var product3 = new Product("Thingamajig", 303, 39.99m, 3);

        // Create orders and add products to them
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: {order.GetTotalPrice():C}\n");
    }
}

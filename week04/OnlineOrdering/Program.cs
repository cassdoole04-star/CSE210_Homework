using System;

class Program
{
    static void Main(string[] args)
    {
       // Order 1: USA Customer ($5 shipping) with 3 products
        Address address1 = new Address("456 Oak Ave", "Orem", "UT", "USA");
        Customer customer1 = new Customer("Luke Garrets", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mechanical Keyboard", "KB-101", 79.99, 1));
        order1.AddProduct(new Product("Mouse Pad", "MP-202", 14.50, 2));
        order1.AddProduct(new Product("Webcam Cover", "WC-303", 6.00, 1));

        DisplayOrderDetails("ORDER 1", order1);

        // Order 2: International Customer ($35 shipping) with 2 products
        Address address2 = new Address("78 Maple St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jordan Taylor", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Portable SSD", "SD-401", 110.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "HC-505", 12.25, 2));

        DisplayOrderDetails("ORDER 2", order2);
    }

    static void DisplayOrderDetails(string title, Order order)
    {
        Console.WriteLine($"==================== {title} ====================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
        Console.WriteLine("====================================================\n");
    }
}
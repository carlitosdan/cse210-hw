using System;

class Program
{
    static void Main(string[] args)
    {

        //Add some products
        Product p1 = new Product(1, "Laptop Lenovo i5", 1200.50, 2);
        Product p2 = new Product(2, "Sunglasses Ry Ban", 282.00, 1);
        Product p3 = new Product(3, "High-Pressure Water Gun", 35.00, 1);

        //Add an Address
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("Calle 1 Mz B", "Cieneguilla", "Lima", "Peru");

        //Create a Customer
        Customer customer1 = new Customer("Theodore Enn", address1);
        Customer customer2 = new Customer("Juan Perez", address2);

        //Create an Order
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);
        Order order2 = new Order(customer2);
        order2.AddProduct(p2);
        order2.AddProduct(p1);

        //show labels and total cost

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel() + "\n");
        Console.WriteLine($"Shipping Cost: ${order1.GetShippingCost()}");
        Console.WriteLine($"Total order: ${order1.getTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel() + "\n");
        Console.WriteLine($"Shipping Cost: ${order2.GetShippingCost()}");
        Console.WriteLine($"Total order: ${order2.getTotalCost()}\n");










    }
}
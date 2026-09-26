using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Johnathan Dough", address1);
        Customer customer2 = new Customer("Janeifer Smithing", address2);

        Product product1 = new Product("Bread", 101, 9.99, 3);
        Product product2 = new Product("Milk", 102, 4.99, 2);
        Product product3 = new Product("Eggs", 103, 1.49, 12);

        Product product4 = new Product("Television", 201, 499.99, 1);
        Product product5 = new Product("Laptop", 202, 999.99, 1);
        Product product6 = new Product("Fridge", 203, 349.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine($"Order 1 Total: ${order1.GetOrderTotal():0.00}");
        order1.GetShippingLabel();
        order1.GetPackingLabel();
        
        Console.WriteLine($"Order 2 Total: ${order2.GetOrderTotal():0.00}");
        order2.GetShippingLabel();
        order2.GetPackingLabel();
        
    }
}
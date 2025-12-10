using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("John Way", "Maple City", "Kansas", "USA");
        Customer customerOne = new Customer("Mary Poppleton", addressOne);
        Order orderOne = new Order(customerOne);


        orderOne.AddProduct(new Product("Apples", 400197, 1, 15));
        orderOne.AddProduct(new Product("Ramen", 401653, 3, 3));
        orderOne.AddProduct(new Product("Paper Towels", 402558, 2, 7));


        Console.WriteLine(orderOne.PackageLabel());
        Console.WriteLine(orderOne.ShippingLabel());
    }
}
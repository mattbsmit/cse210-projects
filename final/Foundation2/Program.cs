using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("John Way", "Maple City", "Kansas", "USA");
        Customer customerOne = new Customer("Mary Poppleton", addressOne);
        Order orderOne = new Order(customerOne);


        Product productOne = new Product("Paper Towels", 402558, 2, 7);
        Product productTwo = new Product("Ramen", 401653, 3, 3);
        Product productThree = new Product("Apples", 400197, 1, 15);


        orderOne.AddProduct(productOne.productString());
        orderOne.AddProduct(productTwo.productString());
        orderOne.AddProduct(productThree.productString());

        orderOne.AddCost(productOne.ProductCost());
        orderOne.AddCost(productTwo.ProductCost());
        orderOne.AddCost(productThree.ProductCost());


        orderOne.PackageLabel();
        orderOne.ShippingLabel();




        Address addressTwo = new Address("Speeding Lane", "Vatican", "Isla Nublar", "Honduras");
        Customer customerTwo = new Customer("Joan Adams", addressTwo);
        Order orderTwo = new Order(customerTwo);


        Product productFour = new Product("Paper Towels", 402558, 2, 7);
        Product productFive = new Product("Ramen", 401653, 3, 3);
        Product productSix = new Product("Apples", 400197, 1, 15);


        orderTwo.AddProduct(productFour.productString());
        orderTwo.AddProduct(productFive.productString());
        orderTwo.AddProduct(productSix.productString());

        orderTwo.AddCost(productFour.ProductCost());
        orderTwo.AddCost(productFive.ProductCost());
        orderTwo.AddCost(productSix.ProductCost());


        orderTwo.PackageLabel();
        orderTwo.ShippingLabel();
    }
}
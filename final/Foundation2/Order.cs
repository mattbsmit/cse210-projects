class Order
{
    private Customer _customer;
    private Product _product;
    private double _totalCost;
    private int _shipping;


    List<Product> order = new List<Product>();


    public Order(Customer customer)
    {
        _customer = customer;
    }


    public void AddProduct(Product product)
    {
        order.Add(_product);
    }

    public bool PackageLabel()
    {
        Console.WriteLine("PACKAGE LABEL:");

        foreach (var i in order)
        {
            Console.WriteLine(i);
        }


        //GetCost();
        Console.WriteLine($"Total Cost: ${_totalCost}");
        return true;
    }

    public bool ShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL: ");

        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress().GetAddress()}");
        return false;
    }

    private double GetCost()
    {
        _totalCost = 0;

        foreach (var i in order)
        {
            _totalCost += i.ProductCost();
        }

        if (_customer.IsUSA())
        {
            _totalCost += _totalCost + 5;
        }
        else
        {
            _totalCost += _totalCost + 35;
        }

        return _totalCost;
    }
}
class Order
{
    private Customer _customer;
    private string _product;
    private double _totalCost;
    private bool _shipping;


    List<string> order = new List<string>();


    public Order(Customer customer)
    {
        _customer = customer;
    }


    public void AddProduct(string product)
    {
        _product = product;
        order.Add(_product);
    }

    public void PackageLabel()
    {
        Console.WriteLine("PACKAGE LABEL:");

        foreach (var i in order)
        {
            Console.WriteLine(i);
        }

        ExtraShipping();
        if (_shipping)
        {
            _totalCost += 5;
        }

        else
        {
            _totalCost += 35;
        }

        Console.WriteLine($"Total Cost: ${_totalCost}");
    }

    public void ShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL: ");

        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress().GetAddress()}");
    }

    public double AddCost(double cost)
    {
        _totalCost += cost;
        return _totalCost;
    }

    private bool ExtraShipping()
    {
        _shipping = _customer.IsUSA();
        return _shipping;
    }
}
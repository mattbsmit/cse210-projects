class Product
{
    private string _product;
    private int _productID;
    private int _price;
    private int _quantity;
    private double _totalCost;


    public Product(string product, int productID, int Price, int quantity)
    {
        _product = product;
        _productID = productID;
        _price = Price;
        _quantity = quantity;
    }


    public double ProductCost()
    {
        _totalCost += _price * _quantity;
        return _totalCost;
    }

    public string productString()
    {
        Console.WriteLine($"{_product}, {_productID}, {_productID}, {_price}, {_quantity}");
        return $"Product: {_product} ProductID: {_productID} Price: {_price} Quantity: {_quantity}";
    }

}
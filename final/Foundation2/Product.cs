using System.Diagnostics.Contracts;

class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, int productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product: {_productName}");
        Console.WriteLine($"ID #: {_productId}");
        Console.WriteLine($"Price: ${_price}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Total Price: ${GetProductTotal()}");
    }

    public double GetProductTotal()
    {
        return _price * _quantity;
    }
}
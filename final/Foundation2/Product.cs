using System.Diagnostics.Contracts;

class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetProductTotal()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"Product: {_productName}\nID #: {_productId}\nItem Price: ${_price}\nQuantity: {_quantity}\nItem Total Price: ${GetProductTotal()}\n";
    }
}
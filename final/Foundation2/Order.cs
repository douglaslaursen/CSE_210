class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetProductTotal();
        }

        // Add shipping
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.GetPackingInfo() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
    }

    public void DisplayOrder()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------ Order ------------------------");
        DisplayPackingLabel();
        DisplayShippingLable();
        Console.WriteLine();
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("-------- Packing Label --------");
        Console.WriteLine(GetPackingLabel());
    }
    
    public void DisplayShippingLable()
    {
        Console.WriteLine("-------- Shipping Label --------");
        Console.WriteLine(GetShippingLabel());
    }
}
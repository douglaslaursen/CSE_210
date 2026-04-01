class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_customerName}: {_customerAddress.GetAddress()}");
    }

    public bool LivesInUSA()
    {
        return _customerAddress.IsUSA();
    }

    public string GetName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }
}
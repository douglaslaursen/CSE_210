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
}
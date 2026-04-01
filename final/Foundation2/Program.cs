using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address = new Address("ads", "asdf", "asdf", "asdf");
        Customer customer = new Customer("Bob", address);

        customer.DisplayCustomer();
    }
}
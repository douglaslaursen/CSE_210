class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // First Order (USA)
        Address address1 = new Address("1100 W", "Salt Lake", "UT", "USA");
        Customer customer1 = new Customer("Bob your uncle", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));

        // Second Order (International)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P2001", 600, 1));
        order2.AddProduct(new Product("Charger", "P2002", 20, 3));
        order2.AddProduct(new Product("Headphones", "P2003", 50, 1));


        // Display Order 1
        order1.DisplayOrder();
        Console.WriteLine("Shipping: $5");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");
        
        // Display Order 2
        order2.DisplayOrder();
        Console.WriteLine("Shipping: $35");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine();
    }
}
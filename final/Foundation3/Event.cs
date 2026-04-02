class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        // Lists of title, description, date time, and address
        Console.WriteLine();
        Console.WriteLine($"{_title}, {_description}, {_date}, {_time}, {_address.GetAddress()}");
        Console.WriteLine();
    }

    public void DisplayShortDetails()
    {
        // Lists the type of event, title, and the date
        Console.WriteLine();
        Console.WriteLine($"{_type}: {_title}, {_date}");
        Console.WriteLine();
    }
}
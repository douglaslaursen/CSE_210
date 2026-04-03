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

    public string GetStandardDetails()
    {
        // Lists of title, description, date time, and address
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nPlease join us @: {_address.GetAddress()}";
    }

    public string GetShortDetails()
    {
        // Lists the type of event, title, and the date
        return $"{_type}: {_title}, {_date}";
    }
}
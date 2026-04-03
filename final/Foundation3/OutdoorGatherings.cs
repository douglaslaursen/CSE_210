class OutdoorGatherings : Event
{
    private string _weatherBeLike;

    public OutdoorGatherings(string weatherBeLike, string title, string description, string date, string time, Address address) 
    : base("Out Door Gathering", title, description, date, time, address)
    {
        _weatherBeLike = weatherBeLike;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather: {_weatherBeLike}";
    }
}
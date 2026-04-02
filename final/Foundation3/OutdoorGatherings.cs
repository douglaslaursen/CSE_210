class OutDoorGatherings : Event
{
    private string _weatherBeLike;

    public OutDoorGatherings(string weatherBeLike, string title, string description, string date, string time, Address address) 
    : base("Out Door Gathering", title, description, date, time, address)
    {
        _weatherBeLike = weatherBeLike;
    }

    public void DisplayFullDetails()
    {
        
    }
}
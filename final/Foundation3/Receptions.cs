class Receptions : Event
{
    
    private string _rsvp;

    public Receptions(string rsvp, string title, string description, string date, string time, Address address) 
    : base("Reception", title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_rsvp}";
    }
}
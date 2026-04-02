class Receptions : Event
{
    
    private int _rsvp;

    public Receptions(int rsvp, string title, string description, string date, string time, Address address) 
    : base("Reception", title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    

    public void DisplayFullDetails()
    {
        
    }
}
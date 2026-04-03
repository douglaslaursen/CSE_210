class Lectures : Event
{
    private int _maxCapcity;
    private string _speakerName;

    public Lectures(int maxCapcity, string speakerName, string title, string description, string date, string time, Address address) 
    : base("Lecture", title, description, date, time, address)
    {
        _maxCapcity = maxCapcity;
        _speakerName = speakerName;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {_speakerName}\nCapacity: {_maxCapcity}";
    }
}
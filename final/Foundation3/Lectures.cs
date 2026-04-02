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

    public void DisplayFullDetails()
    {
        Console.WriteLine();
        DisplayStandardDetails();
        Console.WriteLine($"The speaker will be {_speakerName}. The max Copacity is {_maxCapcity}.\nHope to see you there");
        Console.WriteLine();
    }
}
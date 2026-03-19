class Activity
{
    private string _name;
    private string _discription;
    private int _duration;
    private DateTime _endTime;

    public Activity(string name, string discription)
    {
        _name = name;
        _discription = discription;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine($"Weldome to the {_name} Activity.");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_discription);
    }

    
    
}
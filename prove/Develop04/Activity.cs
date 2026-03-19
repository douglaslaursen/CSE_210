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

    public void DisplayEnding()
    {
        Console.WriteLine("Well done!!");
    }

    public void DisplaySpinner(string message, int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        int sleepTime = 100;
        string animationString = "-\\|/";
        int index = 0;

        Console.CursorVisible = false;
        Console.Clear();

        Console.Write($"{message}");

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }

        Console.CursorVisible = true;
    }

    public void RunCountDown(string message, int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine($"{message}");
    }
    
}
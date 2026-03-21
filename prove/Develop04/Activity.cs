class Activity
{
    private string _name;
    private string _discription;
    protected int _duration;
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
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_discription);
    }

    public void DisplayDuration()
    {
        Console.Write("How long, in seconds, would you like for your session: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEnding()
    {
        Console.WriteLine($"Well Done!! \n\nYou have completed another {_duration} second of the {_name} Activity");
    }

    public void DisplaySpinner(string message, int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        int sleepTime = 100;
        string animationString = "-\\|/";
        int index = 0;

        Console.CursorVisible = false;

        Console.Write($"{message}");

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        Console.Write(" ");

        Console.CursorVisible = true;
    }

    public void RunCountDown(string message, int seconds)
    {
        Console.CursorVisible = false;

        Console.Write($"{message}");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write(" \b");

        Console.CursorVisible = true;
    }

    public void IntroActivity()
    {
        Console.Clear();
        DisplayGreeting();
        Console.WriteLine();
        DisplayDescription();
        Console.WriteLine();
        DisplayDuration();
        
        Console.Clear();
        DisplaySpinner("Get ready...", 3);
        Console.WriteLine();
        Console.WriteLine();
    }
}
class ReflectionActivity : Activity
{
    private List<string> _promts;
    private List<string> _questions;
    private List<int> _used = new();

    public ReflectionActivity(List<string> prompts, List<string> questions)
    : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ")
    {
        _promts = prompts;
        _questions = questions;
    }

    public void RunReflectionActivity()
    {
        IntroActivity();

        Console.WriteLine("Consider the following prompt:\n");

        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they ralate to this experience.");
        RunCountDown("You may begin in: ", 5);

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        Console.Clear();
        while (DateTime.Now < endTime)
        {
            DisplaySpinner(GetRandomQuestion(), 7);
            Console.WriteLine();
        }

        DisplayEnding();
        DisplaySpinner("", 5);
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int RandomIndex = random.Next(0, _promts.Count);
        return $"--- {_promts[RandomIndex]} ---";
    }

    public string GetRandomQuestion()
    {  
        Random random = new();

        int RandomIndex = random.Next(0, _questions.Count);
        while (_used.Contains(RandomIndex))
        {
            RandomIndex = random.Next(0, _questions.Count());
        }
        _used.Add(RandomIndex);

        return _questions[RandomIndex];
    }
}
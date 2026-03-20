class ListingActivity : Activity
{
    private List<string> _promts;
    private List<string> _items;

    public ListingActivity(List<string> prompts, List<string> items)
    : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _promts = prompts;
        _items = items;
    }

    public void RunListingActivity()
    {
        IntroActivity();

        Console.WriteLine("List as many responses you can to the following prompt:\n");

        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine();
        RunCountDown("You may begin in: ", 5);
        Console.WriteLine();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {_items.Count()} items");

        DisplayEnding();
        DisplaySpinner("", 10);
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int RandomIndex = random.Next(0, _promts.Count);
        return $"--- {_promts[RandomIndex]} ---";
    }
}
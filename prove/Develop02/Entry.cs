class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _scripture;

    List<string> _prompts = new List<string>
    {
        "How was your day? ",
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What was the hardest thing you overcame today? ",
    };

    List<string> _scriptures = new List<string>
    {
        "5: If any of you lack wisdome let him ask of God. - James 1:5",
        "ect.."
    };

    public void DisplayScripture()
    {
        Random scripture = new Random();
        int idx = scripture.Next(_scriptures.Count);
        _scripture = _scriptures[idx];
        Console.WriteLine(_scripture);
    }

    public void CreateEntry()
    {
        Random rnd = new Random();
        int idx = rnd.Next(_prompts.Count);
        _prompt = _prompts[idx];
        _date = DateTime.Now.ToShortDateString();
        Console.Write(_prompt);
        _response = Console.ReadLine();
    }

    public void displayResponse()
    {
        Console.WriteLine(CreateFileSystemString());
    }

    public string CreateFileSystemString()
    {
        string outputString = $"{_date}: {_prompt}: \n{_response}";
        return outputString;
    }

}
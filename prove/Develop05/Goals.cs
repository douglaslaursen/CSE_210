using System.IO.Enumeration;

class Goals
{
    private int _totalScore;
    private List<Goal> _goals;

    public Goals()
    {
        _totalScore = 0;
        _goals = [];
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayScore()
    {
        Console.Write($"You have {_totalScore} points.\n");
    }

    private string ObtainFileName()
    {
        string filename;
        Console.WriteLine("Please enter the file name: ");
        filename = Console.ReadLine();
        return filename;
    }

    public void LoadGoals()
    {
        string filename = ObtainFileName();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // string[] parts = line.Split('#');

            // Entry entry = new Entry();
            // entry._date = parts[0];
            // entry._prompt = parts[1];
            // entry._response = parts[2];

            // AddEntry(entry);
        }
    }

    public void SaveGoals()
    {
        string filename = ObtainFileName();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score#{_totalScore}");
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }
    }

    public void DisplayGoals()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count++}. {goal.GetConsoleString()}");
        }

        Console.Write("Press Enter to Continue");
        Console.ReadLine();

    }

    public void RecordEvent()
    {
        
    }

}
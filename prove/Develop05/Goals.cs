using System.IO.Enumeration;

class Goals
{
    private int _totalScore;
    private List<Goal> _goals;
    private string _filename;

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

    public void LoadGoals()
    {
        
    }

    public void SaveGoals()
    {
        
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

    private void ObtainFileName(string prompt)
    {
        
    }
}
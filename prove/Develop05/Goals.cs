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
        
    }

    public void RecordEvent()
    {
        
    }

    private void ObtainFileName(string prompt)
    {
        
    }
}
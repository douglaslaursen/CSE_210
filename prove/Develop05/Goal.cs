using System.IO.Compression;

class Goal
{
    private int _numberOfPoints;
    private bool _status;
    private string _goalName;
    private string _goalDiscription;
    private string _goalType;

    public Goal()
    {
        _goalName = "";
        _goalDiscription = "";
        _status = false;
        _numberOfPoints = 0;
        _goalType = "";
    }

    public void SetName()
    {
        Console.Write("Please enter the name of your goal: ");
        _goalName = Console.ReadLine();
    }

    public virtual string GetConsoleString()
    {
        return $"Goal Information: {_goalName}";
    }


}
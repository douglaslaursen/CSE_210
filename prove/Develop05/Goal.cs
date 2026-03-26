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

    public void SetDiscription()
    {
        Console.Write("Please enter the discrioption of your goal: ");
        _goalDiscription = Console.ReadLine();
    }

    public void SetPoints()
    {
        Console.Write("Please enter the points of your goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    

    public virtual string GetConsoleString()
    {
        return $"Goal Information: {_goalName}, {_goalDiscription}, {_numberOfPoints}";
    }




}
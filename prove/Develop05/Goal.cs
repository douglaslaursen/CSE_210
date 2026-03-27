abstract class Goal
{
    private int _numberOfPoints;
    private bool _status;
    private string _goalName;
    private string _goalDiscription;
    private string _goalType;

    public Goal(string goalName, string goalDiscription, int numberOfPoints, bool status, string type)
    {
        _goalName = goalName;
        _goalDiscription = goalDiscription;
        _status = status;
        _numberOfPoints = numberOfPoints;
    }

    public abstract void CreateGoal();
    public abstract int RecordEvent();

    public virtual string GetConsoleString()
    {
        return $"[ ] {_goalName} ({_goalDiscription}) Worth: {_numberOfPoints}";
    }

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}#{_goalName}#{_goalDiscription}#{_numberOfPoints}";
    }

    public virtual string GetGoalType()
    {
        return $"";
    }

    public void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    }

    public void SetDiscription()
    {
        Console.Write("What is a short description of it? ");
        _goalDiscription = Console.ReadLine();
    }

    public void SetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }





    public void IntroGoal(string goalType)
    {
        SetName();
        SetDiscription();
        SetPoints();
        _goalType = goalType;
    }



}
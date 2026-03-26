abstract class Goal
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

    public abstract void CreateGoal();

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


    public virtual string GetConsoleString()
    {
        return $"[ ] {_goalName} ({_goalDiscription}) {_numberOfPoints}";
    }

    public void IntroGoal()
    {
        SetName();
        SetDiscription();
        SetPoints();
    }


}
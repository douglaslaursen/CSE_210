class ChecklistGoal : Goal
{
    public ChecklistGoal(string goalName, string goalDiscription, int numberOfPoints, bool status, string type, int completions, int max, int bonus) 
    : base(goalName, goalDiscription, numberOfPoints, status, type)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }

    public ChecklistGoal() 
    : base("", "", 0, false, "")
    {

    }

    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public override void CreateGoal()
    {
        _numberOfCompletions = 0;
        
        base.IntroGoal("ChecklistGoal");
        Console.Write("How many times do you want to do this? ");
        _maxGoals = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus you want to recive? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        if(_numberOfCompletions != _maxGoals)
        {
            return _numberOfPoints;
        }
        else
        {
            return MarkComplete();
        }
    }

    public override int MarkComplete()
    {
        _status = true;
        return _numberOfPoints + _bonusPoints;
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} Completed {_numberOfCompletions} out of {_maxGoals} Bonus: {_bonusPoints}";
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}#{_numberOfCompletions}#{_maxGoals}#{_bonusPoints}";
    }
}
class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDiscription, int numberOfPoints, bool status, string type, int completions) 
    : base(goalName, goalDiscription, numberOfPoints, status, type)
    {
        _numberOfCompletions = completions;
    }

    public EternalGoal() 
    : base("", "", 0, false, "")
    {

    }

    private int _numberOfCompletions;

    public override void CreateGoal()
    {
        _numberOfCompletions = 0;
        base.IntroGoal("EternalGoal");
    }

    public override int RecordEvent()
    {
        return MarkComplete();
    }

    public override int MarkComplete()
    {
        _status = false;
        _numberOfCompletions++;
        return _numberOfPoints;
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} Completed {_numberOfCompletions} times";
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}#{_numberOfCompletions}";
    }
}
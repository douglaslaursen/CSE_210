class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDiscription, int numberOfPoints, bool status, int completions) 
    : base("", "", 0, false, "")
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
        base.IntroGoal();
    }

    public override int RecordEvent()
    {
        return 5;
    }

    public override string GetConsoleString()
    {
        return base.GetConsoleString();
    }

    public override string GetFileSystemString()
    {
        return base.GetFileSystemString();
    }
}
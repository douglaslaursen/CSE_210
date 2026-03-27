class ChecklistGoal : Goal
{
    // public ChecklistGoal(string goalName, string goalDiscription, int numberOfPoints, bool status, int completions, int max, int bonus) 
    // : base("", "", 0, false, "")
    // {
    //     _numberOfCompletions = completions;
    //     _maxGoals = max;
    //     _bonusPoints = bonus;
    // }

    public ChecklistGoal() 
    : base("", "", 0, false, "")
    {

    }


    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

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

    private void OptainMaxGoal()
    {
        
    }

    private void ObtainBonusPoints()
    {
        
    }
}
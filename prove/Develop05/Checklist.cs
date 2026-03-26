class ChecklistGoal : Goal
{
    public ChecklistGoal(string goalName, string goalDiscription, int numberOfPoints, bool status, int completions, int max, int bonus) 
    : base("", "", 0, false, "")
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
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
}
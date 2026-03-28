class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDiscription, int numberOfPoints, bool status, string type) 
    : base(goalName, goalDiscription, numberOfPoints, status, type)
    {
        
    }

    public SimpleGoal() : base("", "", 0, false, "")
    {
        
    }

    public override void CreateGoal()
    {
        base.IntroGoal("SimpleGoal");
    }

    public override int RecordEvent()
    {
        return MarkComplete();
    }
}
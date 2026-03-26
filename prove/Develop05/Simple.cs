class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDiscription, int numberOfPoints, bool status) 
    : base("", "", 0, false, "")
    {
        
    }

    public override void CreateGoal()
    {
        base.IntroGoal();


        // Go back to main

    }

    public override int RecordEvent()
    {
        return 5;
    }
}
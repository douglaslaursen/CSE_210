class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
        
    }

    public override void CreateGoal()
    {
        base.SetName();
        base.SetDiscription();
        base.SetPoints();
    }
}
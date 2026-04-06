class Running : Activity
{
    private double _distance;
    public Running(double distance, string date, double duration)
    : base(date, "Running", duration)
    {
        _distance = distance;
    }

    public void GetRunningSummary()
    {
        Console.WriteLine();
        Console.WriteLine($"{base.GetSummary()}Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
        Console.WriteLine();
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
}
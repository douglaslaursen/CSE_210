class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, string date, double duration)
    : base(date, "Cycling", duration)
    {
        _speed = speed;
    }

    public void GetCyclingSummary()
    {
        Console.WriteLine();
        Console.WriteLine($"{base.GetSummary()}Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
        Console.WriteLine();
    }

    public override double GetDistance()
    {
        return _speed * (GetDuration() / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}
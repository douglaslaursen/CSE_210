class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(double numberOfLaps, string date, double duration)
    : base(date, "Swimming", duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2}, Laps: {_numberOfLaps}";
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}
class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, string date, double duration)
    : base(date, "Cycling", duration)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
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
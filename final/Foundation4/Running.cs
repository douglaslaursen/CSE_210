
class Running : Activity
{
    private double _distance;
    public Running(double distance, string date, double duration)
    : base(date, "Running", duration)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
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
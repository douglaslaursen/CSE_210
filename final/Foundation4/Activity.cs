abstract class Activity
{
    private string _date;
    private string _type;
    private double _duration;

    public Activity(string date, string type, double duration)
    {
        _date = date;
        _type = type;
        _duration = duration;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_type} ({_duration} min) - ";
    }
    
    public double GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}
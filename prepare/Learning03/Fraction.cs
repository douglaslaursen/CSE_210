class Fraction
{
    // Step 3
    private int _top;
    private int _bottom;

    public Fraction() // Default constructor this is what C# does automaticlly 
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) // We are making our own constuctor. 
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1;
        }
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
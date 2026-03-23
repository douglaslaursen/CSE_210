using System.Drawing;
using System.Runtime.CompilerServices;

class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public double GetArea()
    {
        int area = 0;
        return area;
    }
}
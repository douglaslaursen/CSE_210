using System;
using System.Runtime.CompilerServices;

class Circle
{
    private double _radius; // Only attrubie in this class

    public Circle() // default constructor this is what C# does automaticlly 
    {
        _radius = 0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)  //set radius    // if you make this private you can only call in this class. 
    {
        if(radius < 0)     // This is gate keeping to make sure the user does not put anything in that would crash the program. 
        {
            Console.WriteLine("Invalid Radius, Must be a positive value.");
            _radius = 0;
        }
        else
            _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }
}
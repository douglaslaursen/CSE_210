using System;
using System.Runtime.CompilerServices;

class Circle
{
    public double _radius; // Only attrubie in this class

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)  //set radius
    {
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
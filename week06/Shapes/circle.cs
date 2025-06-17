using System;
using System.Drawing;

public class Circle : Shape
{
    private double _radius;

    public double GetRad()
    {
        return _radius;
    }
    public void SetRad(double radius)
    {
        _radius = radius;
    }

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }





}
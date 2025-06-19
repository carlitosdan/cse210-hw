using System;

public class Cycling : Activity
{
    private double _speedInKph;

    public Cycling(DateTime date, int lengthInMinutes, double speedInKph)
        : base(date, lengthInMinutes)
    {
        _speedInKph = speedInKph;
    }

    public override double GetSpeed()
    {
        return _speedInKph;
    }

    public override double GetDistance()
    {
        return (_speedInKph * GetLengthInMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speedInKph;
    }
}
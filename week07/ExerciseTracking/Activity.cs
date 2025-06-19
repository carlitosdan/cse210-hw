using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public DateTime GetDateTime(){ return _date; }
    public void SetDateTime(DateTime date){ _date = date; }
    public int GetLengthInMinutes() { return _lengthInMinutes; }
    public void SetLengthInMinutes(int lengthInMinutes){ _lengthInMinutes = lengthInMinutes; }

    //Constructor
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_lengthInMinutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}
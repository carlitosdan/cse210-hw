using System;

public class Fraction
{
    private int _top;
    private int _bottom;
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;

    }

    public string GetFractionString()
    {
        string x = $"{_top}/{_bottom}";
        return x;
    }

    public double GetDecimalValue()
    {
        double n = (double)_top / (double)_bottom;
        return n; 

    }


            
   }
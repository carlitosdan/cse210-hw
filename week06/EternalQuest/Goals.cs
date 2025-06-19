using System;

public class Goals
{
    private string _name;
    private string _description;
    private int _points;

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    public virtual string GetDetails()
    {
        return $"{_name} ({_description})";
    }

    
    public virtual int RecordEvent()
    {
        return _points;
    }


    

   



}
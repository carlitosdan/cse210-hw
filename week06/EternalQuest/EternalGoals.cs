using System;

public class EternalGoals : Goals
{
    public EternalGoals(string name, string description, int points)
        : base(name, description, points)
    {
        
    }

    public override string GetDetails()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override int RecordEvent()
    {
        return GetPoints(); 
    }
    


}
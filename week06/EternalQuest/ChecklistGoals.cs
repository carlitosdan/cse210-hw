using System;

public class ChecklistGoals : Goals
{
    private int _timesCompleted;
    private int _target;
    private int _bonusPoints;


    public int GetTimesCompleted() { return _timesCompleted; }
    public void SetTimesCompleted(int timesCompleted) { _timesCompleted = timesCompleted; }
    public int GetTarget() { return _target; }
    public void SetTarget(int target) { _target = target; }
    public int GetBonusPoints(){ return _bonusPoints; }
    public void SetBonusPoints(int bonusPoints){ _bonusPoints = bonusPoints; }

    public ChecklistGoals(string name, string description, int points, int target, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonusPoints = bonusPoints;
    }

    public override string GetDetails()
    {
        //return $"[ ] {GetName()} ({GetDescription()}) -- Completed {GetTimesCompleted()}/{GetTarget()}";
        return $"[ ] {GetName()} ({GetDescription()}) -- Progress {GetVisual()}";
    }
    
    public override int RecordEvent()
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted = _timesCompleted + 1;
            if (_timesCompleted == _target)
            {
                Console.WriteLine("Congratulations! You earned a bonus!");
                return GetPoints() + _bonusPoints;
            }
            return GetPoints();
        }
        else
        {
            Console.WriteLine("This checklist goal is completed.");
            return 0;
        }
    }

    public string GetVisual()
    {
        string result = "";
        for (int i = 0; i < _timesCompleted; i++)
        {
            result += "[X] ";
        }
        for (int i = _timesCompleted; i < _target; i++)
        {
            result += "[ ] ";
        }
        return result.Trim();
    }


    


}
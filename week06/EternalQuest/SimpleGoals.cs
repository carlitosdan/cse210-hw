using System;

public class SimpleGoals : Goals
{
    private bool _isComplete;

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool IsComplete)
    {
        _isComplete = IsComplete;
    }

    public SimpleGoals(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override string GetDetails()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()})";
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
           return GetPoints();
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
    }
    






}
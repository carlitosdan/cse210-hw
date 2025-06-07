using System;

public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
       
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        return $"Names: {_studentName} - Topic: {_topic}";
    }

   
}
using System;
using System.Data.SqlTypes;
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetWritingInformation()
    {
        string sn = GetStudentName();
        return $"{_title} by {sn}";
    }


}
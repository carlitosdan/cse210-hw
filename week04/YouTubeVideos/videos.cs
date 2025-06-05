using System;

public class videos
{
    private string _title = "";
    private string _author = "";
    private int _lenghtS = 0;
    private List<comment> _ListComments = new List<comment>();


    public videos(string title, string author, int lenghtS)
    {
        _title = title;
        _author = author;
        _lenghtS = lenghtS;

    }

    public void AddComment(comment newComment)
    {
        _ListComments.Add(newComment);
    }

    public int GetNumberOfComments()
    {
        return _ListComments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_lenghtS}");
        foreach (var c in _ListComments)
        {
            Console.WriteLine($"- {c.GetComment()} ");
        }
    }












}
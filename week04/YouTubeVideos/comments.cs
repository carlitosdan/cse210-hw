using System;
using System.Diagnostics.CodeAnalysis;

public class comment
{
    private string _authorName = "";
    private string _commentText = "";

    public comment(string authorName, string commentText)
    {
        _authorName = authorName;
        _commentText = commentText;

    }

    public string GetComment()
    {
        return $"{_authorName}: {_commentText} ";
    }


    








}
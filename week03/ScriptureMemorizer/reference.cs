using System;

public class Reference
{
    private string _Book = "";
    private int _chapter = 0;
    private int _verse = 0;
    private int _endVerse = 0;

    public Reference(string Book, int chapter, int verse, int? endVerse = null)
    {
        _Book = Book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse ?? 0;
    }

    public string GetDisplayText()
    {
        string endVerseText = _endVerse == 0 ? "" : $"-{_endVerse}";
        return $"{_Book} {_chapter}:{_verse}{endVerseText}";
    } 

}
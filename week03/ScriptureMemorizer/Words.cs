using System;

public class Words
{
    private string _word;
    private bool _isHidden;

    public Words(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }


    public void Hide()
    {
        _isHidden = true;
    }

    public bool GetIsHidden()
    {
         return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _word;
    }
    


    

    



}
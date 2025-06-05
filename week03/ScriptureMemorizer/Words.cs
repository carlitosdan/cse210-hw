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
        if (_isHidden)
        {
            string xString = "";
            int digit = _word.Length;
            for (int i = 0; i < digit; i++)
            {
                xString = "_" + xString;
            }

            return xString;

        }
        else
        {
         return _word; 
        }


        
    }
    


    

    



}
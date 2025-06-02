using System;

public class Scripture
{
    private Reference _refer;
    public List<Words> _words = new List<Words>();


    public Scripture(Reference refer, string textScripture)
    {
        _refer = refer;
        _words = textScripture.Split(' ').Select(Word => new Words(Word, false)).ToList();
    }

    //I can to access to _refer object value from Program.cs
    public Reference GetReference()
    {
        return _refer;
    }

    public string GetReferenceText()
    {
        return _refer.GetDisplayText(); 
    }

    
   

    public bool HideRandomWords()
    {
        //Take the visible words of the List and save indexes in another List
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].GetIsHidden())
            {
                visibleIndexes.Add(i);
            }
        }
        // Take 3 or less numbers for hidden words.
        int wordsToHide = Math.Min(3, visibleIndexes.Count);

        if (wordsToHide == 0)
        {
            return false;
        }

        //let's go order by aleatory.
        Random random = new Random();
        visibleIndexes = visibleIndexes.OrderBy(x => random.Next()).ToList();

        // And now hidde words in the array.
        for (int i = 0; i < wordsToHide; i++)
        {
            _words[visibleIndexes[i]].Hide();
        }

        return true;
    }


    public void DisplayScripture()
    {
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }

        Console.WriteLine();
    }



}




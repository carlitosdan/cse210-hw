using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;

public class TakeJson
{
    private class ScriptureData
    {
        public string book { get; set; }
        public int chapter { get; set; }
        public int verse { get; set; }
        public int? endVerse { get; set; }
        public string text { get; set; }
    }

    // Get the filepath of the json file. 
    private string _filePath;
    public TakeJson(string filePath)
    {
        _filePath = filePath;
    }

    public Scripture GetRandomScripture()
    {

        string myJson = File.ReadAllText(_filePath);

        //Create a List ScriptureData Class 
        List<ScriptureData> scriptures = JsonSerializer.Deserialize<List<ScriptureData>>(myJson);

        if (scriptures == null || scriptures.Count == 0)
        {
            throw new Exception("No scriptures found in the JSON file.");
        }

        

        Random random = new Random();
        int ind = random.Next(scriptures.Count);
        // Chose a random scripture from List scriptures and save into ScriptureData class.
        ScriptureData chosen = scriptures[ind];

        
        // Add to Reference class from ScriptureData
        Reference reference = new Reference(chosen.book, chosen.chapter, chosen.verse, chosen.endVerse);
        //Instantiate with constructor in Scripture class
        Scripture scripture = new Scripture(reference, chosen.text);


        return scripture;

    }



}
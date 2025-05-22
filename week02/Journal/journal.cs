using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class journal(){
    public string _names    { get; set; } = "";
    public List<entry> _myEntry { get; set; } = new List<entry>();

    
    public void  AddEntry(entry newEntry){
        _myEntry.Add(newEntry);
    }

    public void displayAll(){
        if (_myEntry.Count == 0){Console.WriteLine("No entries to display"); return;}

        Console.WriteLine("-----------------------");
        Console.WriteLine("This is your Journal");
        Console.WriteLine("-----------------------");

        foreach (var entry in _myEntry)
        {
            Console.WriteLine("Date: " + entry._dateEntry.ToShortDateString());
            Console.WriteLine("Prompt: " + entry._promptText);
            Console.WriteLine("Response: " + entry._entryText);
            Console.WriteLine("-----------------------------");
        }
    }

    public void SaveToFile(string fileName)
    {
        Console.WriteLine("---------------------------------------");
        string jsonString = JsonSerializer.Serialize(_myEntry, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine($"Journal saved to {fileName}");
        Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
        Console.WriteLine("---------------------------------------");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename)){
            Console.WriteLine("File not found.");  
            return;
            }

        string myJson = File.ReadAllText(filename);

        // Deserialize into a temporary journal object
        // var loadedJournal = JsonSerializer.Deserialize<journal>(myJson);
        var loadedEntries = JsonSerializer.Deserialize<List<entry>>(myJson);

        if (loadedEntries != null)
        {
             _myEntry.Clear();
             _myEntry.AddRange(loadedEntries);
             Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("Failed to load journal data.");
        }
}



   

}
        
public class entry(){
    public string _promptText {get; set;}
    public string _entryText {get; set;}
    public DateTime _dateEntry {get; set;}




    

    public void displayEntry()
    {
        Console.WriteLine($"Last Entry:");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"{_dateEntry.ToShortDateString()}");

    }

    
}
        
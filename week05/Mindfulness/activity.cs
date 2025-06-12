using System;

public class Activity
{
    protected string _nameActivity;
    protected string _descriptionActivity;

    protected int _durationActivity;

    public Activity()
    {

    }

    public Activity(string nameActivity, string descriptionActivity, int durationActivity)
    {
        _nameActivity = nameActivity;
        _descriptionActivity = descriptionActivity;
        _durationActivity = durationActivity;

    }

    public Activity(int durationActivity)
    {
       
        _durationActivity = durationActivity;

    }

    public void displayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_nameActivity}");
        Console.WriteLine($" {_descriptionActivity}");
        Console.Write("how many seconds would you like your session to be?: ");
        _durationActivity = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        
    }

    public void displayEndingMessage()
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You have completed {_durationActivity} seconds of the {_nameActivity}.");
        ShowSpinner(5);
        Console.Clear();
    }


    public void ShowSpinner(int sec)
    {
        var spinner = new[] { "|", "/", "-", "\\" };
        var endTime = DateTime.Now.AddSeconds(sec);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(100); // Delay
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Go back one character
            i++;
        }

        Console.WriteLine(); // Move to next line after spinner


    }
    
    public static void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.SetCursorPosition(Console.CursorLeft - i.ToString().Length, Console.CursorTop);
        }

        Console.WriteLine(); // Move to a new line after countdown
    }
     
    public string GetRandomPrompt(List<string> prompts)
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }



}
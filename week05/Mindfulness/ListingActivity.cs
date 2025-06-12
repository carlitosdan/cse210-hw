using System;

public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "his activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {

    }



    public void run()
    {
        displayStartingMessage();

        string myprompt = GetRandomPrompt(_prompts);


        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {myprompt} ---");
        Console.WriteLine("You may begin in:");
        ShowCountdown(8);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_durationActivity);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        

        displayEndingMessage();


    }


}
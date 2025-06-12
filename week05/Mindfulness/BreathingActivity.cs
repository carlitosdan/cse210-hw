using System;

public class BreathingActivity : Activity
{


    public BreathingActivity() :
    base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.\nClear your mind and focus on your breathing.", 0)
    {

    }

    public void run()
    {
        displayStartingMessage();
        int interval = 5; 
        int cycles = _durationActivity / (interval * 2); // each cycle is 10 seconds

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(interval);

            Console.Write("Now breathe out... ");
            ShowCountdown(interval);

            Console.WriteLine(); // space between cycles
        }

        displayEndingMessage();

    }
        
        
}
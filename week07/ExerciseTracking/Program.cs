using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime myDate = new DateTime(2025, 11, 3);

        Running running = new Running(myDate, 20, 5.5);
        Cycling cy = new Cycling(myDate, 60, 30);
        Swimming sw = new Swimming(myDate, 30, 20);
        activities.Add(running);
        activities.Add(cy);
        activities.Add(sw);
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}
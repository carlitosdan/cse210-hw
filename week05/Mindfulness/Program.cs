using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu options:\n 1. Start breathing activity.\n 2. Start reflecting activity.\n 3. Start listing activity.\n 4. Quit.");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.run();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.run(); 
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.run();
                    break;

                case "4":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        }

    }
}
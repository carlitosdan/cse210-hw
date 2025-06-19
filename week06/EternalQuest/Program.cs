using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu options:\n 1. Create New Goal.\n 2. List Goals.\n 3. Save Goals\n 4. Load Goals.\n 5. Record Event.\n 6. Quit.\n Select a choice from the menu: ");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":

                    manager.CreateGoal();
                    break;

                case "2":
                    manager.ListGoals();
                    break;

                case "3":
                    Console.Write("Enter the name of your Goals file: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;

                case "4":
                    Console.Write("Enter the name of your Goals file: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);

                    break;

                case "5":
                    manager.RecordEvent();
                    break;

                case "6":
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
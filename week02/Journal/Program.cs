using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
       
       prompt myPrompt = new prompt();

       myPrompt._question.Add("Who was the most interesting person I interacted with today?");
       myPrompt._question.Add("What was the best part of my day?");
       myPrompt._question.Add("How did I see the hand of the Lord in my life today?");
       myPrompt._question.Add("What was the strongest emotion I felt today?");
       myPrompt._question.Add("If I had one thing I could do over today, what would it be?");

       

       journal myJournal = new journal();

       int opt = 0;
       while(opt!= 5){
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.Write("5. Exit ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // Get random index
                    int myr = prompt.getRandomQuestion(myPrompt._question.Count());
                    //Display random question and get response 
                    Console.WriteLine (myPrompt._question[myr]);
                    string ne = Console.ReadLine();
                    //Add entry to class entry
                    entry newEntry = new entry();
                    newEntry._dateEntry = DateTime.Now;
                    newEntry._promptText = myPrompt._question[myr];
                    newEntry._entryText = ne;

                    //Add entry to list in journal class
                    myJournal.AddEntry(newEntry);
                    break;

                case "2":
                    
                    //Display all entries in journal
                    myJournal.displayAll();
                    
                    break;

                case "3":
                    //For to exceed the requirements I using json for save and load operation
                    myJournal.SaveToFile("myjournal.json");
                    break;

                case "4":
                    //For to exceed the requirements I using json for save and load operation
                    myJournal.LoadFromFile("myjournal.json");
                    break;

                case "5":
                    Console.WriteLine("Exiting the program...");
                    opt= 5;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine(); // Add a blank line for better readability
        };









       
      
    }
}
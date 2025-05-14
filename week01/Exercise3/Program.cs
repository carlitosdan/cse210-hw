using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        string mn = Console.ReadLine();

        Console.WriteLine("What is your guess?");
        string yn = Console.ReadLine();

        int magicNumber = int.Parse(mn);
        int yourNumber = int.Parse(yn);

        if(yourNumber == magicNumber){
            Console.WriteLine("You guessed it!");
        }
        else if(yourNumber > magicNumber){
            Console.WriteLine("Higher");
        }
        else if(yourNumber < magicNumber){
            Console.WriteLine("Lower");
        }
        




    }
}
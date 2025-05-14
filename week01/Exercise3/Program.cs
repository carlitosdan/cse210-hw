using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //string mn = Console.ReadLine();
        //int magicNumber = int.Parse(mn);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int yourNumber = 0;

        

       while(magicNumber != yourNumber ){
            Console.WriteLine("What is your guess?");
            string yn = Console.ReadLine();
            yourNumber = int.Parse(yn);

            if(yourNumber > magicNumber){
                Console.WriteLine("Higher");
            }
            else if(yourNumber < magicNumber){
                Console.WriteLine("Lower");
            }


       }

        if(yourNumber == magicNumber){
            Console.WriteLine("You guessed it!");
        }
        



       
        





    }
}
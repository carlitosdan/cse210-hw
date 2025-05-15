using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
                Console.WriteLine("Welcome to the program!");
        } 
        DisplayWelcome();


        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int sNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, sNumber);

        static void DisplayResult(string name, int number){
        Console.WriteLine($"{name }, the square of your number is {number} ");
        } 

    }

    

    static string PromptUserName(){

            Console.WriteLine("Please enter your name: ");
            string un = Console.ReadLine();
            return un;
            

        }
    static int PromptUserNumber(){

            Console.WriteLine("Please enter your favorite number: ");
            string fn = Console.ReadLine();
            return int.Parse(fn);
            

        }

    static int SquareNumber(int number){
        int sn = number * number;

        return sn; 

    }   

    

}
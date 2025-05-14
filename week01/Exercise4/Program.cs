using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        

        string n = "";
        int number = 0;
        int mySum = 0;
        do{
            Console.WriteLine("Enter number: ");
            n = Console.ReadLine();
            number = int.Parse(n);
            if (number != 0){
                numbers.Add(number);
                mySum = mySum + number;

            }
        }while(number != 0);

        Console.WriteLine("");
        Console.WriteLine($"The sum is: {mySum}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.AsQueryable().Max()}");
        Console.WriteLine($"The smallest number is: {numbers.AsQueryable().Min()}");
        Console.WriteLine("The numbers are: ");
        numbers.Sort();
        foreach(int nu in numbers){

            Console.WriteLine(nu);

        }

        





        
    }
}
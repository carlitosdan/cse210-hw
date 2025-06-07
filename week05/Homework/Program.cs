using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Juan Vargas", "Geographic");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment math1 = new MathAssignment("Section 7.4", "5-10", "Luis", "math 1");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeWorkList());
        Console.WriteLine();

        WritingAssignment w1 = new WritingAssignment("The Causes of World War II", "Liam", "European History");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());

        
        
    }
}
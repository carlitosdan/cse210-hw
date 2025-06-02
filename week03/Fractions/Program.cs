using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Fraction fr1 = new Fraction(1, 3);
        Console.WriteLine(fr1.GetFractionString());
        Console.WriteLine(fr1.GetDecimalValue());

        Fraction fr2 = new Fraction();
        Console.WriteLine(fr2.GetFractionString());
        Console.WriteLine(fr2.GetDecimalValue());

        Fraction fr3 = new Fraction(8);
        Console.WriteLine(fr3.GetFractionString());
        Console.WriteLine(fr3.GetDecimalValue());






    }
    

   

}
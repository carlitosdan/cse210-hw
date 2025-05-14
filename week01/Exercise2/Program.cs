using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter  you grade percentage: ");
        string gp = Console.ReadLine();
        char sd = gp[1];
        int gradePercent = int.Parse(gp);
        int secondDigit = int.Parse(sd.ToString());
        string letter = "";

        if(gradePercent >= 90){
            letter = "A";
        }
        else if(gradePercent >= 80){
            letter = "B";
        }
        else if(gradePercent >= 70){
            letter = "C";
        }
        else if(gradePercent >= 60){
            letter = "D";
        }
        
        if (secondDigit >= 7){
                letter += "+";
            }
            if (secondDigit < 3){
                letter += "-";
            }

        if(gradePercent < 60){
            letter = "F";
        } 
           
        Console.WriteLine($"Your grade is {letter}");

        if(gradePercent >= 70){
            Console.WriteLine("Congratulations! You passed the course");

        }




    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();

        job1._company = "Mirosoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1990;
        job1._endYear = 2012;


        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2020;
        job2._endYear = 2023;

        job2.DisplayJobDetails();

        Resume myresume = new Resume();
        myresume._jobs.Add(job1);
        

        string x = myresume._jobs[0]._jobTitle;

        Console.WriteLine(x);
        







        



    }
}
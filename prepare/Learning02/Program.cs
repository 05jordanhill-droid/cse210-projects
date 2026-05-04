using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Engineer";
        job1._startYear = 2000;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "HR";
        job2._startYear = 2005;
        job2._endYear = 2007;

        Resume jobs = new Resume();

        jobs._name = "Jordan Hill";

        jobs._jobs.Add(job1);
        jobs._jobs.Add(job2);
        
        jobs.Display();
    }
}
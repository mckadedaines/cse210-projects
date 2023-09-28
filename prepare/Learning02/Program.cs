using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // This handles all of the first jobs information
        Job job1 = new Job();
        Console.WriteLine("What's your company's name?");
        job1.Company = Console.ReadLine();
        Console.WriteLine("What is your job title?");
        job1.JobTitle = Console.ReadLine();
        Console.WriteLine("What year did you start?");
        job1.StartYear = int.Parse(Console.ReadLine());
        Console.WriteLine("What year did you leave?");
        job1.EndYear = int.Parse(Console.ReadLine());
        job1.DisplayJobDetails();

        // This handles all the second jobs information
        Job job2 = new Job();
        Console.WriteLine("What's your company's name?");
        job2.Company = Console.ReadLine();
        Console.WriteLine("What is your job title?");
        job2.JobTitle = Console.ReadLine();
        Console.WriteLine("What year did you start?");
        job2.StartYear = int.Parse(Console.ReadLine());
        Console.WriteLine("What year did you leave?");
        job2.EndYear = int.Parse(Console.ReadLine());
        job2.DisplayJobDetails();

        Resume file = new Resume();

        Console.WriteLine("Whats your name?");
        file.Name = Console.ReadLine();

        file.AddJob(job1);
        file.AddJob(job2);

        file.Display();
    }
}
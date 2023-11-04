using System;
using System.Threading;

// Base class for all activities
public abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    // Constructor
    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    // Method to set the duration of the activity
    protected void SetDuration()
    {
        Console.Write("Please set the duration for this activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
    }

    // Start message
    protected void StartMessage()
    {
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine(Description);
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        Countdown(5); // 5-second countdown to start
    }

    // Countdown timer
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // Wait for a second
        }
        Console.WriteLine();
    }

    // Common spinner animation
    protected void Spinner(int seconds)
    {
        Console.Write("Please wait ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // 1 second delay
        }
        Console.WriteLine();
    }

    // End message
    protected void EndMessage()
    {
        Console.WriteLine("You have done a good job!");
        Spinner(3); // Show spinner for 3 seconds
        Console.WriteLine($"You have completed {Name} for {Duration} seconds.");
        Countdown(5); // 5-second countdown to end
    }

    // Abstract method for running the activity
    public abstract void RunActivity();
}

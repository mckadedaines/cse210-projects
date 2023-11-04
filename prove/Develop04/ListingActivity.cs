using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {}

    public override void RunActivity()
    {
        StartMessage();
        Countdown(5); // Countdown before starting the listing

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Keep listing items:");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items.");
        EndMessage();
    }
}

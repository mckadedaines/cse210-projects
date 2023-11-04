using System;
using System.Collections.Generic;

public class MenuSystem
{
    private List<Activity> activities = new List<Activity>();

    public MenuSystem()
    {
        activities.Add(new BreathingActivity());
        activities.Add(new ReflectionActivity());
        activities.Add(new ListingActivity());
        activities.Add(new MindfulnessActivity());
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please choose an activity by entering the number:");
        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {activities[i].GetType().Name}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < activities.Count)
        {
            activities[choice].RunActivity();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}

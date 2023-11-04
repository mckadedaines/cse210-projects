using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        // ... other prompts
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        // ... other questions
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.") {}

    public override void RunActivity()
    {
        StartMessage();
        Random rand = new Random();
        int elapsed = 0;

        while (elapsed < Duration)
        {
            string prompt = Prompts[rand.Next(Prompts.Count)];
            Console.WriteLine(prompt);
            Spinner(3); // Show spinner for 3 seconds

            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                Spinner(5); // Reflect for 5 seconds

                elapsed += 5;
                if (elapsed >= Duration) break;
            }
        }
        EndMessage();
    }
}

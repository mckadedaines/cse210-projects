using System;

class Program
{
    static void Main(string[] args)
    {
        int gradePercentage;

        string letter = "";

        // Converts the users input from a string to an int so we can accurately compare an int to an int and will ONLY accept a number.
        while (true)
        {
            Console.WriteLine("Please enter your grade percentage: ");

            if (int.TryParse(Console.ReadLine(), out gradePercentage))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        // Checks the students grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got an {letter}!");

        // Checks to see if the student passed or failed the class
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry! You Failed!");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Need input magic number
        Console.WriteLine("What's the magic number: ");
        int magic_number = int.Parse(Console.ReadLine());
        // Need user guess
        int user_guess;
        // Needs to run an infinite loop until the user guesses it correctly.
        while (true)
        {
            Console.WriteLine("Guess the magic number: ");
            user_guess = int.Parse(Console.ReadLine());
            if (user_guess == magic_number)
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
                break;
            }
            else if (user_guess < magic_number)
            {
                Console.WriteLine("Try guessing higher.");
            }
            else
            {
                Console.WriteLine("Try guessing lower.");
            }
        }
    }
}
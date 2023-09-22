using System;

namespace FunctionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int favoriteNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(favoriteNumber);

            DisplayResult(userName, squaredNumber);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            int number;

            while (true)
            {
                Console.Write("Enter your favorite number: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            return number;
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, your favorite number squared is: {squaredNumber}");
        }
    }
}

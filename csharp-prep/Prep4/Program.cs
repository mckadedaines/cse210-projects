using System;
using System.Collections.Generic;

namespace NumberListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            // Collect numbers from the user until they enter 0
            while (true)
            {
                Console.Write("Enter a number (0 to stop): ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num == 0)
                        break;

                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }

            // Compute the sum of the numbers
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Compute the average of the numbers
            double average = (double)sum / numbers.Count;

            // Find the maximum number in the list
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Maximum: {max}");
        }
    }
}

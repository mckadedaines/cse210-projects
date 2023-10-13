using System;

namespace ScriptureApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

            while (true)
            {
                Scripture scripture = scriptureLibrary.GetRandomScripture();

                while (!scripture.AllWordsAreBlank())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetFullScripture());
                    scripture.ReplaceWordsWithBlanks(3);

                    Console.WriteLine("Press enter to continue or type \"quit\" to finish:");
                    string userInput = Console.ReadLine();
                    if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    {
                        return; // Exit the entire program
                    }
                }

                Console.WriteLine("All words in this scripture are now blank. Press enter for a new scripture or type \"quit\" to finish:");
                string choice = Console.ReadLine();
                if (choice.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}

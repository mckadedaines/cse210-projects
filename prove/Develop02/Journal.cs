using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

public class Journal
{
    private List<Entry> entries;
    private string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Do you feel like you got closer to your goals today? Why?"
    };

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry()
    {
        string date = DateTime.Now.ToString("dd/MM/yyyy");
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        entries.Add(new Entry(date, prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Enter filename:");
        string filename = Console.ReadLine();
        using StreamWriter writer = new StreamWriter(filename);
        using CsvWriter csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
        csv.WriteRecords(entries);
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Enter filename:");
        string filename = Console.ReadLine();
        entries.Clear();
        using StreamReader reader = new StreamReader(filename);
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower()
        };
        using CsvReader csv = new CsvReader(reader, config);
        entries = csv.GetRecords<Entry>().ToList();
    }
}

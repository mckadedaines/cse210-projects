using CsvHelper.Configuration.Attributes;

public class Entry
{
    [Name("Date")]
    public string Date { get; set; }

    [Name("Prompt")]
    public string Prompt { get; set; }

    [Name("Response")]
    public string Response { get; set; }


    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}, Prompt: {Prompt}, Response: {Response}";
    }

    public string ToCSV()
    {
        return $"{Date},{Prompt},{Response}";
    }
}

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
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

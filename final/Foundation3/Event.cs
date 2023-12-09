public abstract class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    public virtual string GetStandardDetails()
    {
        return $"{Title}: {Description} on {Date.ToShortDateString()} at {Time}, Location: {Address}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name} - {Title} on {Date.ToShortDateString()}";
    }
}

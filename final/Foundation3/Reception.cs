public class Reception : Event
{
    public string RSVP_Email { get; set; }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, RSVP at: {RSVP_Email}";
    }
}

public class MindfulnessActivity : Activity
{
    public MindfulnessActivity() : base("Mindfulness", "This activity will guide you through a session of mindfulness to help you become more present.") {}

    public override void RunActivity()
    {
        StartMessage();
        Console.WriteLine("Please focus on the present moment. We will start with a short meditation.");
        Spinner(Duration); // Simulates the meditation time
        EndMessage();
    }
}

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public override void RunActivity()
    {
        StartMessage();
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(5);
            elapsed += 5;

            if (elapsed >= Duration) break;

            Console.WriteLine("Breathe out...");
            Countdown(5);
            elapsed += 5;
        }
        EndMessage();
    }
}

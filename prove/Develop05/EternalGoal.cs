public class EternalGoal : Goal
{
    public EternalGoal(string name, int points, string description) : base(name, points, description) { }

    public override void RecordProgress()
    {
        _isComplete = true;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_isComplete ? "X" : " ")}] {_name} ({Description}) - {_points} points (Eternal)");
    }

}

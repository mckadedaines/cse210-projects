public class ChecklistGoal : Goal
{
    private int _completionCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, string description, int completionCount, int bonusPoints)
        : base(name, points, description)
    {
        _completionCount = completionCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public int CompletionCount => _completionCount;
    public int CurrentCount => _currentCount;
    public int BonusPoints => _bonusPoints;

    public override void RecordProgress()
    {
        if (!_isComplete)
        {
            _currentCount++;
            if (_currentCount >= _completionCount)
            {
                _isComplete = true;
                _points += _bonusPoints;
            }
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_isComplete ? "X" : " ")}] {_name} ({Description}) - {_points} points, {_currentCount}/{_completionCount} completed, Bonus: {_bonusPoints}");
    }
}

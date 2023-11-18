public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isComplete;
    public string Description { get; set; }

    protected Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        Description = description;
        _isComplete = false;
    }

    public string Name => _name;
    public int Points => _points;
    public abstract void RecordProgress();
    public abstract void DisplayGoal();
    public bool IsComplete => _isComplete;
}

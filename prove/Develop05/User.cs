using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class User
{
    private List<Goal> _goals;
    private int _totalPoints;

    public User()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoal(string goalName)
    {
        var goal = _goals.FirstOrDefault(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));
        if (goal != null)
        {
            goal.RecordProgress();
            if (goal is EternalGoal)
            {
                _totalPoints += goal.Points;
                Console.WriteLine($"Congratulations! You have earned {goal.Points} points!");
            }
            else if (!goal.IsComplete)
            {
                Console.WriteLine($"{goalName} is in progress.");
            }
            else
            {
                _totalPoints += goal.Points;
                Console.WriteLine($"Congratulations on completing {goalName}! You have earned {goal.Points} points!");
            }
            Console.WriteLine($"You now have {_totalPoints} points.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            goal.DisplayGoal();
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine($"Points earned: {_totalPoints}");
            foreach (var goal in _goals)
            {
                string goalType = goal.GetType().Name;
                string additionalInfo = "";
                if (goal is ChecklistGoal checklistGoal)
                {
                    additionalInfo = $"|{checklistGoal.CompletionCount}|{checklistGoal.CurrentCount}|{checklistGoal.BonusPoints}";
                }
                file.WriteLine($"{goalType}:{goal.Name}|{goal.Description}|{goal.Points}{additionalInfo}");
            }
        }
    }



    public void LoadGoals(string filename)
{
    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    _goals.Clear();

    foreach (var line in File.ReadAllLines(filename))
    {
        if (string.IsNullOrWhiteSpace(line)) continue;

        if (line.StartsWith("Points earned:"))
        {
            _totalPoints = int.Parse(line.Split(':')[1].Trim());
        }
        else
        {
            var parts = line.Split(':');
            var goalData = parts[1].Split('|');
            var goalType = parts[0];
            var name = goalData[0];
            var description = goalData[1];
            var points = int.Parse(goalData[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(name, points, description));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, points, description));
                    break;
                case "ChecklistGoal":
                    int completionCount = int.Parse(goalData[3]);
                    int currentCount = int.Parse(goalData[4]);
                    int bonusPoints = int.Parse(goalData[5]);
                    var checklistGoal = new ChecklistGoal(name, points, description, completionCount, bonusPoints);
                    for (int i = 0; i < currentCount; i++)
                    {
                        checklistGoal.RecordProgress();
                    }
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }
}



    public int TotalPoints => _totalPoints;
}

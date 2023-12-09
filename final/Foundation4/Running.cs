using System;

// Derived class for Running
public class Running : Activity
{
    private double distance; // In kilometers

    public Running(DateTime date, double minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / minutes) * 60;
    public override double GetPace() => minutes / distance;
}

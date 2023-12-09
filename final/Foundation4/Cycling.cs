using System;

// Derived class for Cycling
public class Cycling : Activity
{
    private double speed; // In kilometers per hour

    public Cycling(DateTime date, double minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * minutes) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}

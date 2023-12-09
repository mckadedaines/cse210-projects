using System;

// Derived class for Swimming
public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, double minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0;
    public override double GetSpeed() => GetDistance() / (minutes / 60);
    public override double GetPace() => minutes / GetDistance();
}

using System;

// Base class for all activities
public abstract class Activity
{
    protected DateTime date;
    protected double minutes;

    public Activity(DateTime date, double minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    // Virtual methods for calculations
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0; // In kilometers per hour
    public virtual double GetPace() => 0; // In minutes per kilometer

    // Summary method
    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} - {this.GetType().Name} ({minutes} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
}

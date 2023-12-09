public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Weather Forecast: {WeatherForecast}";
    }
}

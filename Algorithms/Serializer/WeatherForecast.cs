﻿namespace Serializer
{
    internal class HighLowTemps
    {
        public int High { get; set; }
        public int Low { get; set; }
    }

    internal class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int? TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
        public string? SummaryField;
        public IList<DateTimeOffset>? DatesAvailable { get; set; }
        public Dictionary<string, HighLowTemps>? TemperatureRanges { get; set; }
        public string[]? SummaryWords { get; set; }
    }
}

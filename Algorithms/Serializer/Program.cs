// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Serializer;

var weatherForecast = new WeatherForecast
{
    Date = DateTime.Parse("2023-08-01"),
    TemperatureCelsius = 25,
    Summary = "Hot",
    //SummaryField = "Hot",
    DatesAvailable = new List<DateTimeOffset>()
                    { DateTime.Parse("2019-08-01"), DateTime.Parse("2019-08-02") },
    TemperatureRanges = new Dictionary<string, HighLowTemps>
    {
        ["Cold"] = new HighLowTemps { High = 20, Low = -10 },
        ["Hot"] = new HighLowTemps { High = 60, Low = 20 }
    },
    SummaryWords = new[] { "Cool", "Windy", "Humid" }
};

var settings = new JsonSerializerSettings
{
    Converters = new List<JsonConverter> { new TranslateJsonConverter() },
    ContractResolver = new CamelCasePropertyNamesContractResolver(),
    NullValueHandling = NullValueHandling.Ignore,
    Formatting = Formatting.None    
};

string json = JsonConvert.SerializeObject(weatherForecast, settings);
Console.WriteLine(json);

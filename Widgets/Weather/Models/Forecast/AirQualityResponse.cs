using System.Text.Json.Serialization;

namespace Weather.Models.Forecast;

public class AirQualityResponse
{
    [JsonPropertyName("current")]
    public CurrentAirQuality Current { get; set; }
    
    [JsonPropertyName("error")]
    public string Error { get; set; }
    
    [JsonPropertyName("reason")]
    public string Reason { get; set; }
}
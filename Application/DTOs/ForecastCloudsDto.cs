using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherConsoleClient.Application.DTOs
{
    public class ForecastCloudsDto
    {
        [JsonPropertyName("all")]
        public int Percentage { get; set; }
    }
}

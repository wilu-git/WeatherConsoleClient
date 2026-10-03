using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConsoleClient.Configuration
{
    internal class OpenWeatherOptions
    {
        public string BaseUrl { get; set; } = string.Empty;

        public string ApiKey { get; set; } = string.Empty;

        public string Units { get; set; } = "metric";
    }
}

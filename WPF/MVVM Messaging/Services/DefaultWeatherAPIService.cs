using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Configuration;
using System.Text.Json;

namespace MVVM_Messaging.Services
{
    public class DefaultWeatherAPIService : IWeatherAPIService
    {
        private readonly string apiKey = ConfigurationManager.AppSettings.Get("apikey");
        public Forecast GetForecast(string cityName)
        {
            using var client = new WebClient();
            string result = null;
            try
            {
                result = client.DownloadString(@$"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}");
            } catch (WebException)
            {
                return null;
            }
            return JsonSerializer.Deserialize<Forecast>(result);
        }

        public Forecast GetForecast(float lat, float lon)
        {
            using var client = new WebClient();
            string result = null;
            try
            {
                result = client.DownloadString(@$"http://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}");
            }
            catch (WebException)
            {
                return null;
            }
            return JsonSerializer.Deserialize<Forecast>(result);
        }
    }
}

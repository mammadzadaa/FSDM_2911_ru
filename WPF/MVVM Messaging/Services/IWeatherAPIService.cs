using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Services
{
    public interface IWeatherAPIService
    {
        Forecast GetForecast(string cityName);
        Forecast GetForecast(float lat, float lon);
    }
}

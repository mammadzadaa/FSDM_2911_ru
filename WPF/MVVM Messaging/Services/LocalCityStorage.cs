using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Services
{
    public class LocalCityStorage : ICityStorage
    {
        private static List<Forecast> cities = new List<Forecast>();
        public void AddCity(Forecast forecast)
        {
            if (forecast == null)
            {
                throw new ArgumentNullException("forecast cannot be null");
            }
            cities.Add(forecast);
        }

        public IEnumerable<Forecast> GetCities()
        {
            return cities;
        }
    }
}

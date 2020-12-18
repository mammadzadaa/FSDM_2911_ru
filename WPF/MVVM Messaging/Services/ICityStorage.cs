using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Services
{
    public interface ICityStorage
    {
        IEnumerable<Forecast> GetCities();
        void AddCity(Forecast forecast);
    }
}

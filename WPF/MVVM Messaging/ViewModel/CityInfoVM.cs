using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Maps.MapControl.WPF;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.ViewModel
{
    public class CityInfoVM : ViewModelBase
    {
        public CityInfoVM()
        {
            messenger = App.container.GetInstance<Messenger>();
            messenger.Register<ForecastMessage>(this, m =>
            {
                currentForecast = m.Forecast;
            });
        }
        public string ImageSrc => $"http://openweathermap.org/img/wn/{currentForecast.weather[0].icon}.png";
        private Forecast currentForecast;
        private Messenger messenger;
        public string CityName => currentForecast.name;
        public string Temp => currentForecast.main.temp.ToString();
        public string Description => currentForecast.weather[0].description;
        public string FeelsLike => currentForecast.main.feels_like.ToString();
        private RelayCommand backCommand;
        public Location Location => new Location(currentForecast.coord.lat, currentForecast.coord.lon);

        public RelayCommand BackCommand => backCommand ??= new RelayCommand(() =>
        {
            messenger.Send(new NavigationMessage() { ViewModel = App.container.GetInstance<CityListVM>() });
        });

    }
}
